using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class ContatoContext : DbContext
    {
        public ContatoContext()
        {
                
        }

        public ContatoContext(DbContextOptions<ContatoContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
