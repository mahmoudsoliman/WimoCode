using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Wimo.Data.Entities;

namespace Wimo.Data
{
    public class WimoDbContext : DbContext
    {
        public WimoDbContext(DbContextOptions<WimoDbContext> options)
        : base(options)
        { }

        public DbSet<Task> Tasks { get; set; }
    }
}
