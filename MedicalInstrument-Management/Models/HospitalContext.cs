using Microsoft.EntityFrameworkCore;

namespace MedicalInstrument_Management.Models
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
            
        } 
        public DbSet<CDHA> CDHA { get; set; }  
    }
}
