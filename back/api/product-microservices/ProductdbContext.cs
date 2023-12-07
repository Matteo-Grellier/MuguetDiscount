using Microsoft.EntityFrameworkCore;

namespace product_microservices
{
    public class ProductdbContext : DbContext
    {
        public ProductdbContext(DbContextOptions<ProductdbContext> options) :base(options)
        { 
        

        } 

        public virtual DbSet<Product> Products { get; set; }
    }
}