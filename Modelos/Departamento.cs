using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiManEm.Modelos
{
    [Table("Departamento")]
    public class Departamento
    {
        [Key]
        public int DepartamentoID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
    }
}
