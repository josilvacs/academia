﻿// <auto-generated />
using System;
using AcademiaCintia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcademiaCintia.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AcademiaCintia.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Fitness"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Dança"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Alongamento"
                        });
                });

            modelBuilder.Entity("AcademiaCintia.Models.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ComentarioData")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ComentarioTexto")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<byte?>("Nota")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.ToTable("Comentario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ComentarioData = new DateTime(2023, 11, 24, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            ComentarioTexto = "Academia top de mais, a melhor não tem.Professores sensacionais e a atenção dobrada em cima dos alunos!!!Vitão e Lopes estão de parabéns 👏🏻🤝🏻",
                            Foto = "/img/testemionial/testemionial-1.jpg",
                            Nome = "Raphael Machado Fernandes",
                            Nota = (byte)5
                        },
                        new
                        {
                            Id = 2,
                            ComentarioData = new DateTime(2023, 11, 24, 19, 0, 0, 0, DateTimeKind.Unspecified),
                            ComentarioTexto = "",
                            Foto = "/img/testemionial/testemionial-2.jpg",
                            Nome = "Deise Kawata",
                            Nota = (byte)5
                        });
                });

            modelBuilder.Entity("AcademiaCintia.Models.Galeria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Galeria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Foto = "/img/gallery/gallery-1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Foto = "/img/gallery/gallery-2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Foto = "/img/gallery/gallery-3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Foto = "/img/gallery/gallery-4.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Foto = "/img/gallery/gallery-5.jpg"
                        },
                        new
                        {
                            Id = 6,
                            Foto = "/img/gallery/gallery-6.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Foto = "/img/gallery/gallery-7.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Foto = "/img/gallery/gallery-8.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Foto = "/img/gallery/gallery-9.jpg"
                        });
                });

            modelBuilder.Entity("AcademiaCintia.Models.Modalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("varchar(600)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Modalidade");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 2,
                            Descricao = "O Ballet Clássico traz diversos benefícios, como melhora da postura, flexibilidade, coordenação motora, força muscular, disciplina, expressão artística e bem-estar mental",
                            Foto = "/img/services/services-1.jpg",
                            Nome = "Ballet Clássico"
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 2,
                            Descricao = "O sapateado traz benefícios como melhora do ritmo, coordenação e consciência corporal. Além disso, é uma forma divertida de exercício que combina música e movimento.",
                            Foto = "/img/services/services-2.jpg",
                            Nome = "Sapateado"
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 2,
                            Descricao = "A Zumba é uma atividade física que combina dança e exercício aeróbico, trazendo benefícios como melhora da resistência cardiovascular, queima de calorias e aumento da coordenação motora.",
                            Foto = "/img/services/services-3.jpg",
                            Nome = "Zumba"
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 2,
                            Descricao = "A dança para crianças traz benefícios como desenvolvimento da coordenação motora, melhora da postura, expressão artística, além de promover a socialização e autoconfiança.",
                            Foto = "/img/services/services-4.jpg",
                            Nome = "Dance Kids"
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 2,
                            Descricao = "A Dance Teen traz benefícios como melhora da coordenação motora, flexibilidade, condicionamento físico e postura. Além disso, a dança promove a expressão, autoconfiança e bem-estar.",
                            Foto = "/img/services/services-5.jpg",
                            Nome = "Dance Teen"
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            Descricao = "A aula das Divas traz benefícios como melhora da flexibilidade, equilíbrio coordenação motora e mobilidade articular. Além disso, a dança promove o convívio social, estimula a memória e melhora o humor.",
                            Foto = "/img/services/services-6.jpg",
                            Nome = "Divas"
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 2,
                            Descricao = " O Fit Dance traz benefícios como melhora do condicionamento físico, queima de calorias, fortalecimento muscular, aumento da coordenação motora e melhora do equilíbrio.",
                            Foto = "/img/services/services-7.jpg",
                            Nome = "Fit Dance"
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 2,
                            Descricao = "O Jazz traz benefícios como desenvolvimento da flexibilidade, força muscular, coordenação motora e resistência cardiovascular.",
                            Foto = "/img/services/services-8.jpg",
                            Nome = "Jazz"
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 1,
                            Descricao = "A musculação é um tipo de exercício realizado com pesos de diversas cargas, amplitude e tempo de contração, o que faz dela uma atividade física indicada para pessoas de diversas idades e com diferentes objetivos.",
                            Foto = "/img/services/services-10.jpg",
                            Nome = "Musculação"
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 1,
                            Descricao = "A aula de Funcional é um esporte que envolve a prática de uma série de movimentos que requer força, flexibilidade e coordenação motora.",
                            Foto = "/img/services/services-12.jpg",
                            Nome = "Funcional"
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = 3,
                            Descricao = "Os exercícios de alongamento promovem um estiramento das fibras musculares,  aumentando a flexibilidade do músculo. O corpo ganha elasticidade, melhorando o desempenho nas atividades físicas e nas tarefas diárias.",
                            Foto = "/img/services/services-11.jpg",
                            Nome = "Alongamento"
                        },
                        new
                        {
                            Id = 12,
                            CategoriaId = 1,
                            Descricao = "Consiste em fazer exercícios diversos utilizando o auxílio de um step. Essa modalidade inclui exercícios que movimentam braços e pernas. A dificuldade do movimento pode ser regulada pela intensidade de movimentos.",
                            Foto = "/img/services/services-13.jpg",
                            Nome = "Step"
                        });
                });

            modelBuilder.Entity("AcademiaCintia.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Facebook")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Instagram")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Professor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cargo = "Diretora",
                            Facebook = "https://www.facebook.com/cintia.reco",
                            Foto = "/img/team/team-1.jpg",
                            Instagram = "https://www.instagram.com/cintiareco/",
                            Nome = "Cintia Reco"
                        },
                        new
                        {
                            Id = 2,
                            Cargo = "Professora Infantil e Juvenil",
                            Facebook = "https://www.facebook.com/raissa.reco",
                            Foto = "/img/team/team-2.jpg",
                            Instagram = "https://www.instagram.com/raissa.recco/",
                            Nome = "Raissa Reco"
                        },
                        new
                        {
                            Id = 3,
                            Cargo = "Professora Infantil",
                            Facebook = "https://www.facebook.com/jooh.silva.1656",
                            Foto = "/img/team/team-3.jpg",
                            Instagram = "https://www.instagram.com/jo.silvacs/",
                            Nome = "Joany Silva"
                        },
                        new
                        {
                            Id = 4,
                            Cargo = "Gym Trainer",
                            Facebook = "https://www.facebook.com/vitor.baldi.5",
                            Foto = "/img/team/team-4.jpg",
                            Instagram = "https://www.instagram.com/vitor.baldi_/",
                            Nome = "Vitor Baldi"
                        },
                        new
                        {
                            Id = 5,
                            Cargo = "Gym Trainer",
                            Facebook = "https://www.facebook.com/roberta.garcia.315",
                            Foto = "/img/team/team-5.jpg",
                            Instagram = "https://www.instagram.com/rogarciadias/",
                            Nome = "Roberta Garcia"
                        },
                        new
                        {
                            Id = 6,
                            Cargo = "Professora de Ballet Adulto",
                            Facebook = "https://www.facebook.com/luana.ruiz.754",
                            Foto = "/img/team/team-6.jpg",
                            Instagram = "https://www.instagram.com/luanaruiiz/",
                            Nome = "Luana Ruiz"
                        },
                        new
                        {
                            Id = 7,
                            Cargo = "Professor de Zumba",
                            Facebook = "https://www.facebook.com/rauldaniel.pinheiro",
                            Foto = "/img/team/team-7.jpg",
                            Instagram = "https://www.instagram.com/rahul_black_swan/",
                            Nome = "Raul Pinheiro"
                        },
                        new
                        {
                            Id = 8,
                            Cargo = "Professora Fit Dance Teen & Kids",
                            Facebook = "https://www.facebook.com/profile.php?id=100015112025441",
                            Foto = "/img/team/team-8.jpg",
                            Instagram = "https://www.instagram.com/tathy.7mene/ ",
                            Nome = "Tathy Meneghesso"
                        });
                });

            modelBuilder.Entity("AcademiaCintia.Models.Usuario", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Foto")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = "f432da76-102b-4771-baf8-114d0c66950e",
                            DataNascimento = new DateTime(1973, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Foto = "/img/users/avatar.png",
                            Nome = "Cintia Reco"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "952f7eaf-c91d-476b-9cdf-dfc02f700115",
                            ConcurrencyStamp = "d1ba2694-97ee-41a4-81b0-74e8f033ad8f",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "7e844028-1ebb-4497-96bb-7fb931b8da19",
                            ConcurrencyStamp = "0917cafd-c328-4386-a049-fbabfea48b3f",
                            Name = "Funcionário",
                            NormalizedName = "FUNCIONARIO"
                        },
                        new
                        {
                            Id = "363db272-c7a6-4bf3-bdc5-0e31e5440649",
                            ConcurrencyStamp = "1884148a-2b01-4d6b-9451-c2896de69aea",
                            Name = "Cliente",
                            NormalizedName = "CLIENTE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f432da76-102b-4771-baf8-114d0c66950e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "00e41f91-07f5-4bb6-8af7-85517882f55f",
                            Email = "admin@academiacintiareco.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ACADEMIACINTIARECO.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEOP0qQctOKn+va1XJFhasHnW+ymeUL9neNHgZD3OjpTY2Lt0cfLXUdXtzSVsbVKf2Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1c634f1d-022f-4309-85b7-ec6e109d789c",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "f432da76-102b-4771-baf8-114d0c66950e",
                            RoleId = "952f7eaf-c91d-476b-9cdf-dfc02f700115"
                        },
                        new
                        {
                            UserId = "f432da76-102b-4771-baf8-114d0c66950e",
                            RoleId = "7e844028-1ebb-4497-96bb-7fb931b8da19"
                        },
                        new
                        {
                            UserId = "f432da76-102b-4771-baf8-114d0c66950e",
                            RoleId = "363db272-c7a6-4bf3-bdc5-0e31e5440649"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AcademiaCintia.Models.Modalidade", b =>
                {
                    b.HasOne("AcademiaCintia.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("AcademiaCintia.Models.Usuario", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "AccountUser")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
