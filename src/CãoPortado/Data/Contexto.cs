using PetHotel.Models;
using Microsoft.EntityFrameworkCore;


namespace PetHotel.Data
{
    public class Contexto : DbContext
    {


        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Clientes> Clientes { get; set; }    
    }
}
