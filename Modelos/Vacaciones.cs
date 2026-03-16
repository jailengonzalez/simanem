using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiManEm.Modelos
{
    [Table("Vacaciones")]
    public class Vacaciones
    {
        [Key]
        public int VacacionID { get; set; }

        [Required]
        public int EmpleadoID { get; set; }
        [ForeignKey("EmpleadoID")]
        public virtual Empleado Empleado { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public DateTime FechaFin { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }
    }
}
