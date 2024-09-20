using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RelationshipRetry.Models
{
    public class RelationshipRetryContext : DbContext
    {
        public RelationshipRetryContext(DbContextOptions<RelationshipRetryContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
