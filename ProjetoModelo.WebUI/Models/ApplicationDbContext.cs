using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ProjetoModelo.WebUI.Models
{
    /// <summary>
    /// Contexto utilizado apenas no ASP.NET Identity e Migratoions
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("ProjetoModeloConnectionString", throwIfV1Schema: false) { }

        public DbSet<Client> Client { get; set; }

        public DbSet<Claims> Claims { get; set; }

        public static ApplicationDbContext Create() => new ApplicationDbContext();
    }
}