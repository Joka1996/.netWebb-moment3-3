using Microsoft.EntityFrameworkCore;
using moment3_3.Models;

namespace moment3_3.Data
{   //ärva
    public class SongContext : DbContext
    {
        public SongContext(DbContextOptions<SongContext> options) : base(options)
        {

        }
        //skapa tabell med dbset
        public DbSet<Songs> Songs { get; set; }
    }
}
