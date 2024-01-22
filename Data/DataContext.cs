using ControlOfPrinters.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControlOfPrinters.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Printer> printers { get; set; }
    }
}
