using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class Cliente
    {
        [Key]
        public int Id_Cliente { get; set; }
        [MaxLength(30)]
        public string Nome { get; set; }
        [MaxLength(11)]
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        [MaxLength(60)]
        public string Endereco { get; set; }
    }
}
