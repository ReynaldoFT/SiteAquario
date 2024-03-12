using Microsoft.EntityFrameworkCore;

namespace SiteAquario.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        // Modelos que o Entity Framework vai gerenciar 

        public DbSet<ValoresSensor> ValoresSensor { get; set; }

    }
}
