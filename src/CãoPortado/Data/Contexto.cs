using PetHotel.Models;
using Microsoft.EntityFrameworkCore;


namespace PetHotel.Data
{
    public class Contexto : DbContext
    {
        protected readonly IConfiguration Configuration;

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        { }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<CadPet> CadPet { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}
