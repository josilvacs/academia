using AcademiaCintia.ViewModels.Account;

namespace AcademiaCintia.Services;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogado();
}