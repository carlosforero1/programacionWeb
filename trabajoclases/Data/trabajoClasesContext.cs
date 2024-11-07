using Microsoft.EntityFrameworkCore;
using trabajoclases.Models;

namespace trabajoclases.Data
{
    public class trabajoclasesContext : DbContext
    {
        public trabajoclasesContext(DbContextOptions<trabajoclasesContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}
