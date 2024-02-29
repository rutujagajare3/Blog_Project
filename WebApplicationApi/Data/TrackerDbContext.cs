using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Models;

namespace WebApplicationApi.Data
{
    public class TrackerDbContext : DbContext
    {
        public TrackerDbContext (DbContextOptions<TrackerDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationApi.Models.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<WebApplicationApi.Models.BlogInfo>? BlogInfo { get; set; }

        public DbSet<WebApplicationApi.Models.EmpInfo>? EmpInfo { get; set; }
    }
}
