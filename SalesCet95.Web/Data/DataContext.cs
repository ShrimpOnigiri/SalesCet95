using Microsoft.EntityFrameworkCore;
using SalesCet95.Web.Data.Entities;


namespace SalesCet95.Web.Data
{
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {
                
            }
            
            public DbSet<Country> Countries { get; set; }

        }
    
}
