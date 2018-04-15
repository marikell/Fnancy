
using Fnancy.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Fnancy.Data
{
    public class FnancyContext: DbContext
    {
        public FnancyContext(DbContextOptions<FnancyContext> options):base(options)
        {
            


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
        }

    }
}
