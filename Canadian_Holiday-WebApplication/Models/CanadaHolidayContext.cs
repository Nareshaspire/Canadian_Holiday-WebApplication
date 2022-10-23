using Microsoft.EntityFrameworkCore;

namespace Canadian_Holiday_WebApplication.Models
{
    public class CanadaHolidayContext
    {
        public CanadaHolidayContext(DbContextOptions<CanadaHolidayContext> options)
           : base(options)
        {
        }

        public DbSet<CanadaHolidays> CanadaHolidays { get; set; }
    }
}

