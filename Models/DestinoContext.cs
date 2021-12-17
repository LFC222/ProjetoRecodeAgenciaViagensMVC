using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class DestinoContext : DbContext
    {
        public DestinoContext()
        {

        }

        public DestinoContext(DbContextOptions<DestinoContext> options) : base(options)
        {

        }

        public DbSet<Destino> Destinos { get; set; }
    }
}
