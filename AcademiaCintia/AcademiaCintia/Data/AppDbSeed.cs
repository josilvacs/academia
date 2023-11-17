using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AcademiaCintia.Models;

namespace AcademiaCintia.Data;

public class AppDbSeed
{

    public AppDbSeed(ModelBuilder builder)
    {
        #region Populate Categoria
        List<Categoria> categorias = new() {
            new () {
                Id = 1,
                Nome = "Fitness"
            },
            new () {
                Id = 2,
                Nome = "Dança"
            },
            new () {
                Id = 3,
                Nome = "Alongamento"
            }
        };
        builder.Entity<Categoria>().HasData(categorias);
        #endregion
        

        #region Populate Categoria
        List<Professor> professores = new() {
            new () {
                Id = 1,
                Nome = "Cintia Reco"
            },
            new () {
                Id = 2,
                Nome = "Raissa Reco"
            },
            new () {
                Id = 3,
                Nome = "Joany Silva"
            },
            new () {
                Id = 4,
                Nome = "Vitor Baldi"
            },
            new () {
                Id = 5,
                Nome = "Roberta Garcia"
            },
            new () {
                Id = 6,
                Nome = "Luana Ruiz"
            },
            new () {
                Id = 7,
                Nome = "Raul Pinheiro"
            },
            new () {
                Id = 8,
                Nome = "Tathy Meneghesso"
            },
            
        };
        builder.Entity<Professor>().HasData(professores);
        #endregion

        #region Populate Categoria
        List<Modalidade> modalidades = new() {
            new () {
                Id = 1,
                Nome = "Ballet Clássico",
                Descricao = "",
                Foto = "/im",
                CategoriaId = 2
            },
            new () {
                Id = 2,
                Nome = "Sapateado"
            },
            new () {
                Id = 3,
                Nome = "Zumba"
            },
            new () {
                Id = 4,
                Nome = "Dance Kids"
            },
            new () {
                Id = 5,
                Nome = "Dance Teen"
            },
            new () {
                Id = 6,
                Nome = "Divas"
            },
            new () {
                Id = 7,
                Nome = "Fit Dance"
            },
            new () {
                Id = 8,
                Nome = "Jazz"
            },
            new () {
                Id = 9,
                Nome = "Musculação"
            },
            new () {
                Id = 10,
                Nome = "Funcional"
            },
            new () {
                Id = 11,
                Nome = "Alongamento"
            },
            new () {
                Id = 12,
                Nome = "Step"
            },
            new () {
                Id = 13,
                Nome = "Zumba"
            },
            
        };
        builder.Entity<Modalidade>().HasData(modalidades);
        #endregion

        

        
        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles = new()
        {
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Funcionário",
               NormalizedName = "FUNCIONARIO"
            },
            new IdentityRole()
            {
               Id = Guid.NewGuid().ToString(),
               Name = "Cliente",
               NormalizedName = "CLIENTE"
            }
        };
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate IdentityUser
        List<IdentityUser> users = new(){
            new IdentityUser(){
                Id = Guid.NewGuid().ToString(),
                Email = "admin@cozastore.com",
                NormalizedEmail = "ADMIN@COZASTORE.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Etec123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "José Antonio Gallo Junior",
                DataNascimento = DateTime.Parse("05/08/1981"),
                Foto = "/img/users/avatar.png"
            }
        };
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles = new()
        {
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[0].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[1].Id
            },
            new IdentityUserRole<string>() {
                UserId = users[0].Id,
                RoleId = roles[2].Id
            }
        };
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }
}