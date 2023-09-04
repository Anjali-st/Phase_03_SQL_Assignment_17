using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApIAssesment_17.Model;

namespace WebApIAssesment_17.Data
{
    public class WebApIAssesment_17DbContext : DbContext
    {
        public WebApIAssesment_17DbContext (DbContextOptions<WebApIAssesment_17DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApIAssesment_17.Model.Movie> Movie { get; set; } = default!;
    }
}
