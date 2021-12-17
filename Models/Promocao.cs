using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class Promocao
    {
        [Key]
        public int Id_Promo { get; set; }
        [Required(ErrorMessage = "Por favor, escolha o  Destino da promoção")]
        public string Destino_Promo { get; set; }
        public float Valor_promo { get; set; }
        [Required(ErrorMessage = "Por favor, indique a quantidade de dias que queira ficar")]
        public int Qntd_Dias { get; set; }
    }
}
