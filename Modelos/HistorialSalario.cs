using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiManEm.Modelos
{
    [Table("HistorialSalario")]
    public class HistorialSalario
    {
        [Key]
        public int HistorialID { get; set; }

        [Required]
        public int EmpleadoID { get; set; }
        [ForeignKey("EmpleadoID")]
        public virtual Empleado Empleado { get; set; }

        [Required]
        public decimal SalarioAnterior { get; set; }

        [Required]
        public decimal SalarioNuevo { get; set; }

        [Required]
        public DateTime FechaCambio { get; set; }
    }
}
