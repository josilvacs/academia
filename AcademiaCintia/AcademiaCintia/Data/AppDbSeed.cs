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
        
        #region Populate Galeria
        List<Galeria> galerias = new() {
            new () {
                Id = 1,
                Foto = "/img/gallery/gallery-1.jpg"
            },
            new () {
                Id = 2,
                Foto = "/img/gallery/gallery-2.jpg"
            },
            new () {
                Id = 3,
                Foto = "/img/gallery/gallery-3.jpg"
            },
            new () {
                Id = 4,
                Foto = "/img/gallery/gallery-4.jpg"
            },
            new () {
                Id = 5,
                Foto = "/img/gallery/gallery-5.jpg"
            },
            new () {
                Id = 6,
                Foto = "/img/gallery/gallery-6.jpg"
            },
            new () {
                Id = 7,
                Foto = "/img/gallery/gallery-7.jpg"
            },
            new () {
                Id = 8,
                Foto = "/img/gallery/gallery-8.jpg"
            },
            new () {
                Id = 9,
                Foto = "/img/gallery/gallery-9.jpg"
            }
        };
        builder.Entity<Galeria>().HasData(galerias);
        #endregion

        #region Populate Professor
        List<Professor> professores = new() {
            new () {
                Id = 1,
                Nome = "Cintia Reco",
                Cargo = "Diretora",
                Foto = "/img/team/team-1.jpg",
                Facebook = "https://www.facebook.com/cintia.reco",
                Instagram = "https://www.instagram.com/cintiareco/"
            },
            new () {
                Id = 2,
                Nome = "Raissa Reco",
                Cargo = "Professora Infantil e Juvenil",
                Foto = "/img/team/team-2.jpg",
                Facebook = "https://www.facebook.com/raissa.reco",
                Instagram = "https://www.instagram.com/raissa.recco/"
            },
            new () {
                Id = 3,
                Nome = "Joany Silva",
                Cargo = "Professora Infantil",
                Foto = "/img/team/team-3.jpg",
                Facebook = "https://www.facebook.com/jooh.silva.1656",
                Instagram = "https://www.instagram.com/jo.silvacs/"
            },
            new () {
                Id = 4,
                Nome = "Vitor Baldi",
                Cargo = "Gym Trainer",
                Foto = "/img/team/team-4.jpg",
                Facebook = "https://www.facebook.com/vitor.baldi.5",
                Instagram = "https://www.instagram.com/vitor.baldi_/"
            },
            new () {
                Id = 5,
                Nome = "Roberta Garcia",
                Cargo = "Gym Trainer",
                Foto = "/img/team/team-5.jpg",
                Facebook = "https://www.facebook.com/roberta.garcia.315",
                Instagram = "https://www.instagram.com/rogarciadias/"
            },
            new () {
                Id = 6,
                Nome = "Luana Ruiz",
                Cargo = "Professora de Ballet Adulto",
                Foto = "/img/team/team-6.jpg",
                Facebook = "https://www.facebook.com/luana.ruiz.754",
                Instagram = "https://www.instagram.com/luanaruiiz/"
            },
            new () {
                Id = 7,
                Nome = "Raul Pinheiro",
                Cargo = "Professor de Zumba",
                Foto = "/img/team/team-7.jpg",
                Facebook = "https://www.facebook.com/rauldaniel.pinheiro",
                Instagram = "https://www.instagram.com/rahul_black_swan/"
            },
            new () {
                Id = 8,
                Nome = "Tathy Meneghesso",
                Cargo = "Professora Fit Dance Teen & Kids",
                Foto = "/img/team/team-8.jpg",
                Facebook = "https://www.facebook.com/profile.php?id=100015112025441",
                Instagram = "https://www.instagram.com/tathy.7mene/ "
            },
            
        };
        builder.Entity<Professor>().HasData(professores);
        #endregion

        #region Populate Modalidade
        List<Modalidade> modalidades = new() {
            new () {
                Id = 1,
                Nome = "Ballet Clássico",
                Descricao = "O Ballet Clássico traz diversos benefícios, como melhora da postura, flexibilidade, coordenação motora, força muscular, disciplina, expressão artística e bem-estar mental",
                Foto = "/img/services/services-1.jpg",
                CategoriaId = 2
            },
            new () {
                Id = 2,
                Nome = "Sapateado",
                Descricao = "O sapateado traz benefícios como melhora do ritmo, coordenação e consciência corporal. Além disso, é uma forma divertida de exercício que combina música e movimento.",
                Foto = "/img/services/services-2.jpg",
                CategoriaId = 2
            },
            new () {
                Id = 3,
                Nome = "Zumba",
                Descricao = "A Zumba é uma atividade física que combina dança e exercício aeróbico, trazendo benefícios como melhora da resistência cardiovascular, queima de calorias e aumento da coordenação motora.",
                Foto = "/img/services/services-3.jpg",
                CategoriaId = 2
            },
            new () {
                Id = 4,
                Nome = "Dance Kids",
                Descricao = "A dança para crianças traz benefícios como desenvolvimento da coordenação motora, melhora da postura, expressão artística, além de promover a socialização e autoconfiança.",
                Foto = "/img/services/services-4.jpg",
                CategoriaId = 2
            },
            new () {
                Id = 5,
                Nome = "Dance Teen",
                Descricao = "A Dance Teen traz benefícios como melhora da coordenação motora, flexibilidade, condicionamento físico e postura. Além disso, a dança promove a expressão, autoconfiança e bem-estar.",
                Foto = "/img/services/services-5.jpg",
                CategoriaId = 2
            },
            new () {
                Id = 6,
                Nome = "Divas",
                Descricao = "A aula das Divas traz benefícios como melhora da flexibilidade, equilíbrio coordenação motora e mobilidade articular. Além disso, a dança promove o convívio social, estimula a memória e melhora o humor.",
                Foto = "/img/services/services-6.jpg",
                CategoriaId = 2
            },
            new () {
                Id = 7,
                Nome = "Fit Dance",
                Descricao = " O Fit Dance traz benefícios como melhora do condicionamento físico, queima de calorias, fortalecimento muscular, aumento da coordenação motora e melhora do equilíbrio.",
                Foto = "/img/services/services-7.jpg",
                CategoriaId = 2
            },
            new () {
                Id = 8,
                Nome = "Jazz",
                Descricao = "O Jazz traz benefícios como desenvolvimento da flexibilidade, força muscular, coordenação motora e resistência cardiovascular.",
                Foto = "/img/services/services-8.jpg",
                CategoriaId = 2
            },
            new () {
                Id = 9,
                Nome = "Musculação",
                Descricao = "A musculação é um tipo de exercício realizado com pesos de diversas cargas, amplitude e tempo de contração, o que faz dela uma atividade física indicada para pessoas de diversas idades e com diferentes objetivos.",
                Foto = "/img/services/services-10.jpg",
                CategoriaId = 1
            },
            new () {
                Id = 10,
                Nome = "Funcional",
                Descricao = "A aula de Funcional é um esporte que envolve a prática de uma série de movimentos que requer força, flexibilidade e coordenação motora.",
                Foto = "/img/services/services-12.jpg",
                CategoriaId = 1
            },
            new () {
                Id = 11,
                Nome = "Alongamento",
                Descricao = "Os exercícios de alongamento promovem um estiramento das fibras musculares,  aumentando a flexibilidade do músculo. O corpo ganha elasticidade, melhorando o desempenho nas atividades físicas e nas tarefas diárias.",
                Foto = "/img/services/services-11.jpg",
                CategoriaId = 3
            },
            new () {
                Id = 12,
                Nome = "Step",
                Descricao = "Consiste em fazer exercícios diversos utilizando o auxílio de um step. Essa modalidade inclui exercícios que movimentam braços e pernas. A dificuldade do movimento pode ser regulada pela intensidade de movimentos.",
                Foto = "/img/services/services-13.jpg",
                CategoriaId = 1
            }
            
        };
        builder.Entity<Modalidade>().HasData(modalidades);
        #endregion
        
        #region Populate Comentario
        List<Comentario> comentarios = new() {
            new () {
                Id = 1,
                Nome = "Raphael Machado Fernandes",
                ComentarioTexto = "Academia top de mais, a melhor não tem.Professores sensacionais e a atenção dobrada em cima dos alunos!!!Vitão e Lopes estão de parabéns 👏🏻🤝🏻",
                ComentarioData = DateTime.Parse("24/11/2023 19:00"),
                Nota = 5,
                Foto = "/img/testemionial/testemionial-1.jpg"
            },
            new () {
                Id = 2,
                Nome = "Deise Kawata",
                ComentarioTexto = "",
                ComentarioData = DateTime.Parse("24/11/2023 19:00"),
                Nota = 5,
                Foto = "/img/testemionial/testemionial-2.jpg"
            }
        };
        builder.Entity<Comentario>().HasData(comentarios);
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
                Email = "admin@academiacintiareco.com",
                NormalizedEmail = "ADMIN@ACADEMIACINTIARECO.COM",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                LockoutEnabled = false,
                EmailConfirmed = true,
            }
        };
        foreach (var user in users)
        {
            PasswordHasher<IdentityUser> pass = new();
            user.PasswordHash = pass.HashPassword(user, "@Academia123");
        }
        builder.Entity<IdentityUser>().HasData(users);

        List<Usuario> usuarios = new(){
            new Usuario(){
                UsuarioId = users[0].Id,
                Nome = "Cintia Reco",
                DataNascimento = DateTime.Parse("13/02/1973"),
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
