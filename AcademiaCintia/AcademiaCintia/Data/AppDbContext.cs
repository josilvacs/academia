using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AcademiaCintia.Models;

namespace AcademiaCintia.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions opcoes) : base(opcoes)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Categoria> Categorias { get; set; }

    public DbSet<Comentario> Comentarios { get; set; }

    public DbSet<Galeria> Galerias { get; set; }
    public DbSet<Modalidade> Modalidades { get; set; }

    public DbSet<Professor> Professores { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed seed = new(builder);
    }

}