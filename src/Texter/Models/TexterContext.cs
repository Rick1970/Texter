using Microsoft.EntityFrameworkCore;

namespace Texter.Models
{
    public class TexterContext : DbContext
    {
        public virtual DbSet<Message> Messages
        {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Texter;integrated security=True");
        }
    }
}
