using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using AcademiaCintia.ViewModels.Account;
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