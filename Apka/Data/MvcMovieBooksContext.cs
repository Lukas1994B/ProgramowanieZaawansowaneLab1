using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
    
{
    public class MvcMovieBooksContext : DbContext
    {
        public MvcMovieBooksContext(DbContextOptions<MvcMovieBooksContext> options)
        : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Books> Books { get; set; }
    }
}
