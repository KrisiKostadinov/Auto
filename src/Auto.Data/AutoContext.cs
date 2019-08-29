using Auto.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auto.Data
{
    public class AutoContext : IdentityDbContext<AutoUser>
    {
        public AutoContext(DbContextOptions<AutoContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<FavouritesUser> FavouritesUser { get; set; }

        public DbSet<NoteUser> NotesUser { get; set; }
    }
}
