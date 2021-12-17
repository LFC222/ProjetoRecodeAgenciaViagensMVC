using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class PromocaoContext : DbContext
    {
        public PromocaoContext()
        {

        }

        public PromocaoContext(DbContextOptions<PromocaoContext> options) : base(options)
        {

        }

        public DbSet<Promocao> Promocaos { get; set; }
     }
}
