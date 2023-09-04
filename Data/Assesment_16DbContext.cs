using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAssesment_16.Models;

namespace WebAppAssesment_16.Data
{
    public class Assesment_16DbContext : DbContext
    {
        public Assesment_16DbContext (DbContextOptions<Assesment_16DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAssesment_16.Models.Task> Task { get; set; } = default!;
    }
}
