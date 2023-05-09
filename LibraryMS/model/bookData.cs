using Microsoft.EntityFrameworkCore;

namespace BookShelf.model
{
    public class bookData:DbContext
    {
        internal IEnumerable<books> db;

        public bookData(DbContextOptions<bookData> options) : base(options)
            {

            }
            public DbSet<books> Books { get; set; }
        }
}
