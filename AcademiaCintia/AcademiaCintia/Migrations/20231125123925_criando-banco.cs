using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaCintia.Migrations
{
    public partial class criandobanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comentario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ComentarioTexto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ComentarioData = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nota = table.Column<byte>(type: "tinyint unsigned", nullable: true),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Galeria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cargo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Facebook = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Instagram = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Modalidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Foto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modalidade_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "00a5e440-2621-47a5-9b96-802f548f984e", "6abc122c-ce98-4cdf-bbe7-9587403dd1e1", "Cliente", "CLIENTE" },
                    { "2b36b12f-0af3-4ed5-a1e8-69127646d94f", "11014ede-3bd6-496e-a5cb-e52eedb5f3bb", "Funcionário", "FUNCIONARIO" },
                    { "aaf63ac9-2bc2-40dc-9f77-17ba2672c22e", "cd8a5bc3-ef83-4b86-b0d8-267185d4ad5b", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2f84cffe-065f-4da9-8852-28b1714ab425", 0, "d0938183-27e9-4913-a6ce-da2af09a48e5", "admin@academiacintiareco.com", true, false, null, "ADMIN@ACADEMIACINTIARECO.COM", "ADMIN", "AQAAAAEAACcQAAAAEE9Wj8Ll3S5SPa8vpqYXR0QHuzO86eyYTFuu/+eijLDjcptHPbxVCwGa/7/urLxAVQ==", null, false, "f711dad8-d0e1-483e-bac1-1f16fece47e8", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Fitness" },
                    { 2, "Dança" },
                    { 3, "Alongamento" }
                });

            migrationBuilder.InsertData(
                table: "Comentario",
                columns: new[] { "Id", "ComentarioData", "ComentarioTexto", "Foto", "Nome", "Nota" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), "Academia top de mais, a melhor não tem.Professores sensacionais e a atenção dobrada em cima dos alunos!!!Vitão e Lopes estão de parabéns 👏🏻🤝🏻", "/img/testemionial/testemionial-1", "Raphael Machado Fernandes", (byte)5 },
                    { 2, new DateTime(2023, 11, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), "", "/img/testemionial/testemionial-2", "Deise Kawata", (byte)5 }
                });

            migrationBuilder.InsertData(
                table: "Galeria",
                columns: new[] { "Id", "Foto" },
                values: new object[,]
                {
                    { 1, "/img/gallery-1" },
                    { 2, "/img/gallery-2" },
                    { 3, "/img/gallery-3" },
                    { 4, "/img/gallery-4" },
                    { 5, "/img/gallery-5" },
                    { 6, "/img/gallery-6" },
                    { 7, "/img/gallery-7" },
                    { 8, "/img/gallery-8" },
                    { 9, "/img/gallery-9" }
                });

            migrationBuilder.InsertData(
                table: "Professor",
                columns: new[] { "Id", "Cargo", "Facebook", "Foto", "Instagram", "Nome" },
                values: new object[,]
                {
                    { 1, "Diretora", "https://www.facebook.com/cintia.reco", "/img/team-1.jpg", "https://www.instagram.com/cintiareco/", "Cintia Reco" },
                    { 2, "Professora Infantil e Juvenil", "https://www.facebook.com/raissa.reco", "/img/team-2.jpg", "https://www.instagram.com/raissa.recco/", "Raissa Reco" },
                    { 3, "Professora Infantil", "https://www.facebook.com/jooh.silva.1656", "/img/team-3.jpg", "https://www.instagram.com/jo.silvacs/", "Joany Silva" },
                    { 4, "Gym Trainer", "https://www.facebook.com/vitor.baldi.5", "/img/team-4.jpg", "https://www.instagram.com/vitor.baldi_/", "Vitor Baldi" },
                    { 5, "Gym Trainer", "https://www.facebook.com/roberta.garcia.315", "/img/team-5.jpg", "https://www.instagram.com/rogarciadias/", "Roberta Garcia" },
                    { 6, "Professora de Ballet Adulto", "https://www.facebook.com/luana.ruiz.754", "/img/team-6.jpg", "https://www.instagram.com/luanaruiiz/", "Luana Ruiz" },
                    { 7, "Professor de Zumba", "https://www.facebook.com/rauldaniel.pinheiro", "/img/team-7.jpg", "https://www.instagram.com/rahul_black_swan/", "Raul Pinheiro" },
                    { 8, "Professora Fit Dance Teen & Kids", "https://www.facebook.com/profile.php?id=100015112025441", "/img/team-8.jpg", "https://www.instagram.com/tathy.7mene/ ", "Tathy Meneghesso" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "00a5e440-2621-47a5-9b96-802f548f984e", "2f84cffe-065f-4da9-8852-28b1714ab425" },
                    { "2b36b12f-0af3-4ed5-a1e8-69127646d94f", "2f84cffe-065f-4da9-8852-28b1714ab425" },
                    { "aaf63ac9-2bc2-40dc-9f77-17ba2672c22e", "2f84cffe-065f-4da9-8852-28b1714ab425" }
                });

            migrationBuilder.InsertData(
                table: "Modalidade",
                columns: new[] { "Id", "CategoriaId", "Descricao", "Foto", "Nome" },
                values: new object[,]
                {
                    { 1, 2, "O Ballet Clássico traz diversos benefícios, como melhora da postura, flexibilidade, coordenação motora, força muscular, disciplina, expressão artística e bem-estar mental", "/img/services/services-1.jpg", "Ballet Clássico" },
                    { 2, 2, "O sapateado traz benefícios como melhora do ritmo, coordenação e consciência corporal. Além disso, é uma forma divertida de exercício que combina música e movimento.", "/img/services/services-2.jpg", "Sapateado" },
                    { 3, 2, "A Zumba é uma atividade física que combina dança e exercício aeróbico, trazendo benefícios como melhora da resistência cardiovascular, queima de calorias e aumento da coordenação motora.", "/img/services/services-3.jpg", "Zumba" },
                    { 4, 2, "A dança para crianças traz benefícios como desenvolvimento da coordenação motora, melhora da postura, expressão artística, além de promover a socialização e autoconfiança.", "/img/services/services-4.jpg", "Dance Kids" },
                    { 5, 2, "A Dance Teen traz benefícios como melhora da coordenação motora, flexibilidade, condicionamento físico e postura. Além disso, a dança promove a expressão, autoconfiança e bem-estar.", "/img/services/services-5.jpg", "Dance Teen" },
                    { 6, 2, "A aula das Divas traz benefícios como melhora da flexibilidade, equilíbrio coordenação motora e mobilidade articular. Além disso, a dança promove o convívio social, estimula a memória e melhora o humor.", "/img/services/services-6.jpg", "Divas" },
                    { 7, 2, " O Fit Dance traz benefícios como melhora do condicionamento físico, queima de calorias, fortalecimento muscular, aumento da coordenação motora e melhora do equilíbrio.", "/img/services/services-7.jpg", "Fit Dance" },
                    { 8, 2, "O Jazz traz benefícios como desenvolvimento da flexibilidade, força muscular, coordenação motora e resistência cardiovascular.", "/img/services/services-8.jpg", "Jazz" },
                    { 9, 1, "A musculação é um tipo de exercício realizado com pesos de diversas cargas, amplitude e tempo de contração, o que faz dela uma atividade física indicada para pessoas de diversas idades e com diferentes objetivos.", "/img/services/services-10.jpg", "Musculação" },
                    { 10, 1, "A aula de Funcional é um esporte que envolve a prática de uma série de movimentos que requer força, flexibilidade e coordenação motora.", "/img/services/services-12.jpg", "Funcional" },
                    { 11, 3, "Os exercícios de alongamento promovem um estiramento das fibras musculares,  aumentando a flexibilidade do músculo. O corpo ganha elasticidade, melhorando o desempenho nas atividades físicas e nas tarefas diárias.", "/img/services/services-11.jpg", "Alongamento" },
                    { 12, 1, "Consiste em fazer exercícios diversos utilizando o auxílio de um step. Essa modalidade inclui exercícios que movimentam braços e pernas. A dificuldade do movimento pode ser regulada pela intensidade de movimentos.", "/img/services/services-13.jpg", "Step" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "DataNascimento", "Foto", "Nome" },
                values: new object[] { "2f84cffe-065f-4da9-8852-28b1714ab425", new DateTime(1973, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "/img/users/avatar.png", "Cintia Reco" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modalidade_CategoriaId",
                table: "Modalidade",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comentario");

            migrationBuilder.DropTable(
                name: "Galeria");

            migrationBuilder.DropTable(
                name: "Modalidade");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
