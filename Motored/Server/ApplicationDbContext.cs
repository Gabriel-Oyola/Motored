using Microsoft.EntityFrameworkCore;
using Motored.Shared.Models;

namespace Motored.Server
{
    public class ApplicationDbContext:DbContext
    { 
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        
        } 

        public DbSet<Usuario>usuarios { get; set; } 
       
        public DbSet<Taller> talleres { get; set; } 

        public DbSet<TallerTop> talleresTop { get; set; } 

        public DbSet<ReporteOpiniones>reporteOpiniones { get; set; }
        public DbSet<Opiniones> opiniones { get; set; }

        public DbSet<Motocicletas> motocicletas { get; set; }
        



    }
}
