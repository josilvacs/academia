using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace AcademiaCintia.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IUserStore<IdentityUser> _userStore;
    private readonly IUserEmailStore<IdentityUser> _emailStore;
    private readonly IWebHostEnvironment _hostEnvironment;

    public AccountController(
        ILogger<AccountController> logger,
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager,
        IUserStore<IdentityUser> userStore,
        IWebHostEnvironment hostEnvironment)
    {
        _logger = logger;
        _signInManager = signInManager;
        _userManager = userManager;
        _userStore = userStore;
        _emailStore = GetEmailStore();
        _hostEnvironment = hostEnvironment;
    }


    [HttpGet]
    public IActionResult Login(string returnUrl)
    {
        LoginVM login = new()
        {
            UrlRetorno = returnUrl ?? Url.Content("~/")
        };
        return View(login);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginVM login)
    {
        if (ModelState.IsValid)
        {
            string userName = login.Email;
            if (IsValidEmail(login.Email))
            {
                var user = await _userManager.FindByEmailAsync(login.Email);
                if (user != null)
                    userName = user.UserName;
            }

            var result = await _signInManager.PasswordSignInAsync(
                userName, login.Senha, login.Lembrar, lockoutOnFailure: true
            );
            if (result.Succeeded)
            {
                _logger.LogInformation($"Usuário {login.Email} acessou o sistema");
                return LocalRedirect(login.UrlRetorno);
            }
            if (result.IsLockedOut)
            {
                _logger.LogWarning($"Usuário {login.Email} está bloqueado");
                return RedirectToAction("Lockout");
            }
            ModelState.AddModelError(string.Empty, "Usuário e/ou Senha Inválidos!!!");
        }
        return View(login);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Logout()
    {
        _logger.LogInformation($"Usuário {ClaimTypes.Email} fez logoff");
        await _signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }


    [HttpGet]
    public IActionResult Register()
    {
        RegisterVM register = new();
        return View(register);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterVM register, IFormFile Foto)
    {
        if (ModelState.IsValid)
        {
            var user = Activator.CreateInstance<IdentityUser>();

            await _userStore.SetUserNameAsync(user, register.Email, CancellationToken.None);
            await _emailStore.SetEmailAsync(user, register.Email, CancellationToken.None);
            var result = await _userManager.CreateAsync(user, register.Senha);

            if (result.Succeeded)
            {
                _logger.LogInformation($"Novo usuário registrado com o email {user.Email}.");

                var userId = await _userManager.GetUserIdAsync(user);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Action(
                    "ConfirmEmail", "Account",
                    new { userId, code },
                    protocol: Request.Scheme);

                await _userManager.AddToRoleAsync(user, "Cliente");

                await _emailSender.SendEmailAsync(register.Email, "CozaStore - Criação de Conta",
                    $"Por favor, confirme a criação de sua conta <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicando aqui</a>.");

                // Cria a conta pessoal do usuário
                Usuario usuario = new()
                {
                    UsuarioId = userId,
                    DataNascimento = register.DataNascimento ?? DateTime.Now,
                    Nome = register.Nome
                };
                if (Foto != null)
                {
                    string fileName = userId + Path.GetExtension(Foto.FileName);
                    string uploads = Path.Combine(_hostEnvironment.WebRootPath, @"images\usuarios");
                    string newFile = Path.Combine(uploads, fileName);
                    using (var stream = new FileStream(newFile, FileMode.Create))
                    {
                        Foto.CopyTo(stream);
                    }
                    usuario.Foto = @"\images\usuarios\" + fileName;
                }
                _contexto.Add(usuario);
                await _contexto.SaveChangesAsync();
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, TranslateIdentityErrors.TranslateErrorMessage(error.Code));
            }
        }
        register.Enviado = ModelState.IsValid;
        return View(register);
    }


    [HttpGet]
    public async Task<IActionResult> ConfirmEmail(string userId, string code)
    {
        if (userId == null || code == null)
        {
            return RedirectToAction("Index", "Home");
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return NotFound($"Não foi possível localizar o usuário.");
        }

        code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
        var result = await _userManager.ConfirmEmailAsync(user, code);
        return View(result.Succeeded);
    }


    [HttpGet]
    public IActionResult Forget()
    {
        ForgetVM forget = new();
        return View(forget);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Forget(ForgetVM forget)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByEmailAsync(forget.Email);
            if (user != null && await _userManager.IsEmailConfirmedAsync(user))
            {
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var callbackUrl = Url.Action(
                    action: "ResetPassword",
                    controller: "Account",
                    values: new { email = forget.Email, code = code },
                    protocol: Request.Scheme);

                await _emailSender.SendEmailAsync(
                    email: forget.Email,
                    subject: "Recuperar Senha",
                    htmlMessage: $"Para definir uma nova senha <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clique aqui</a>.");
            }
        }
        forget.Enviado = ModelState.IsValid;
        return View(forget);
    }


    [HttpGet]
    public IActionResult ResetPassword(string email, string code)
    {
        if (code == null || string.IsNullOrEmpty(email))
        {
            return BadRequest("Solicitação Inválida!!!");
        }
        ResetPasswordVM reset = new()
        {
            //Email = email,
            Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code))
        };
        return View(reset);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPassword)
    {
        if (ModelState.IsValid)
        {
            var user = await _userManager.FindByEmailAsync(resetPassword.Email);
            if (user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, resetPassword.Code, resetPassword.Senha);
                
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, TranslateIdentityErrors.TranslateErrorMessage(error.Code));
                }
            }
        }
        resetPassword.Enviado = ModelState.IsValid;
        return View(resetPassword);
    }


    private IUserEmailStore<IdentityUser> GetEmailStore()
    {
        if (!_userManager.SupportsUserEmail)
        {
            throw new NotSupportedException("The default UI requires a user store with email support.");
        }
        return (IUserEmailStore<IdentityUser>)_userStore;
    }


    private static bool IsValidEmail(string email)
    {
        try
        {
            MailAddress m = new(email);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

}