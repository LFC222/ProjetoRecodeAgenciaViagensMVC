using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class Contato
    {
        [Key]
        public int Id_Contato { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public string Github { get; set; }

    }
}
