using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EspacoX_V3.Models;

namespace EspacoX_V3.Data
{
    public class EspacoX_V3Context : DbContext
    {
        public EspacoX_V3Context (DbContextOptions<EspacoX_V3Context> options)
            : base(options)
        {
        }

        public DbSet<EspacoX_V3.Models.User> User { get; set; } = default!;

        public DbSet<EspacoX_V3.Models.Room>? Room { get; set; }

        public DbSet<EspacoX_V3.Models.Reservation>? Reservation { get; set; }

        public DbSet<EspacoX_V3.Models.Building>? Building { get; set; }

        public DbSet<EspacoX_V3.Models.Admin>? Admin { get; set; }
    }
}
