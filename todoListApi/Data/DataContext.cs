using Microsoft.EntityFrameworkCore;

namespace todoListApi.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Görev> Gorevs => Set<Görev>();
        
    }
}
