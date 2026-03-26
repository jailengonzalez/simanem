using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiManEm.Modelos
{
    [Table("ConfiguracionNomina")]
    public class ConfiguracionNomina
    {
        [Key]
        public int ConfiguracionNominaID { get; set; }

        [Required]
        public decimal PorcentajeAfp { get; set; }

        [Required]
        public decimal PorcentajeArs { get; set; }
    }
}
