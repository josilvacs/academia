using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AcademiaCintia.Models;

namespace AcademiaCintia.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }


    public DbSet<Modalidade> Modalidades { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder) //void não tem retorno
    {
        base.OnModelCreating(builder);
        //AppDbSeed appDbSeed = new(builder);
    
    }
}