using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab26Erik.Models
{
    public class Lab26ErikContext : DbContext
    {
        public Lab26ErikContext (DbContextOptions<Lab26ErikContext> options)
            : base(options)
        {
        }

        public DbSet<Lab26Erik.Models.Product> Product { get; set; }
    }
}
