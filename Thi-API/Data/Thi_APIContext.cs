#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Thi_API.Models;

namespace Thi_API.Data
{
    public class Thi_APIContext : DbContext
    {
        public Thi_APIContext (DbContextOptions<Thi_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Thi_API.Models.Employee> Employee { get; set; }
    }
}
