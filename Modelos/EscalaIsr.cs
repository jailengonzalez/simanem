using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiManEm.Modelos
{
    [Table("EscalaIsr")]
    public class EscalaIsr
    {
        [Key]
        public int EscalaIsrID { get; set; }

        [Required]
        public decimal LimiteInferior { get; set; }

        [Required]
        public decimal LimiteSuperior { get; set; }

        [Required]
        public decimal Tasa { get; set; }

        [Required]
        public decimal CuotaFija { get; set; }
    }
}
