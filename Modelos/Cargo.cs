using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiManEm.Modelos
{
    [Table("Cargo")]
    public class Cargo
    {
        [Key]
        public int CargoID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [Required]
        public int DepartamentoID { get; set; }

        [ForeignKey("DepartamentoID")]
        public virtual Departamento Departamento { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
