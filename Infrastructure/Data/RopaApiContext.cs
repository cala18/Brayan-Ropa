using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class RopaApiContext : DbContext
    {
        public RopaApiContext(DbContextOptions options) : base(options)
        {
        }
    }
}