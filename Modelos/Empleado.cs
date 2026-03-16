using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiManEm.Modelos
{
    [Table("Empleado")]
    public class Empleado
    {
        [Key]
        public int EmpleadoID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int DepartamentoID { get; set; }
        [ForeignKey("DepartamentoID")]
        public virtual Departamento Departamento { get; set; }

        public int CargoID { get; set; }
        [ForeignKey("CargoID")]
        public virtual Cargo Cargo { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        [Required]
        public decimal Salario { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        /// <summary>
        /// Tiempo en la empresa calculado desde FechaInicio
        /// </summary>
        [NotMapped]
        public TimeSpan TiempoEmpresa => DateTime.Now - FechaInicio;

        /// <summary>
        /// AFP - Seguridad social (aproximadamente 2.87% del salario)
        /// </summary>
        [NotMapped]
        public decimal AFP => Math.Round(Salario * 0.0287m, 2);

        /// <summary>
        /// ARS - Seguro de salud (aproximadamente 3.04% del salario)
        /// </summary>
        [NotMapped]
        public decimal ARS => Math.Round(Salario * 0.0304m, 2);

        /// <summary>
        /// ISR - Impuesto sobre la renta (simplificado)
        /// </summary>
        [NotMapped]
        public decimal ISR => CalcularISR(Salario);

        public virtual ICollection<HistorialSalario> HistorialSalarios { get; set; }
        public virtual ICollection<Vacaciones> Vacaciones { get; set; }

        private static decimal CalcularISR(decimal salarioBruto)
        {
            // Escala simplificada del ISR en República Dominicana
            if (salarioBruto <= 416220.00m) return 0;
            if (salarioBruto <= 624329.00m) return Math.Round((salarioBruto - 416220.00m) * 0.15m, 2);
            if (salarioBruto <= 867123.00m) return Math.Round(31216.00m + (salarioBruto - 624329.00m) * 0.20m, 2);
            return Math.Round(79764.00m + (salarioBruto - 867123.00m) * 0.25m, 2);
        }
    }
}
