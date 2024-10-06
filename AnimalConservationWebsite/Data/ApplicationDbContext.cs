using Microsoft.EntityFrameworkCore;
using AnimalConservationWebsite.Models;

namespace AnimalConservationWebsite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ConservationStatus> ConservationStatuses { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

}
