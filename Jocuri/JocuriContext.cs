using Microsoft.EntityFrameworkCore;
using Jocuri.Models.Entities;

namespace Jocuri
{
    public class JocuriContext : DbContext
    {
        public JocuriContext(DbContextOptions<JocuriContext> options)
            : base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
