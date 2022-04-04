using Microsoft.EntityFrameworkCore;
using TackPadApp.Models;

namespace TackPadApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TackPad> TackPad { get; set; }
    }
}
