using Microsoft.EntityFrameworkCore;
using AlfranioForm.Models;

namespace AlfranioForm.Data
{
    public class AlfranioFormContext : DbContext
    {
        public AlfranioFormContext (DbContextOptions<AlfranioFormContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}