using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class Destino
    {
        [Key]
        public int Id_Destino { get; set; }
        [Required(ErrorMessage = "Por favor, escolha o  Destino")]
        public string NomeDestino { get; set; }
        [Required(ErrorMessage = "Por favor, indique a data de ida")]
        public DateTime DataIda { get; set; }
        [Required(ErrorMessage = "Por favor, indique a data de volta")]
        public DateTime DataVolta { get; set; }
    }
}
