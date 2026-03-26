using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SiManEm.Servicios;

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
        /// Tiempo en la empresa calculado en anos y meses
        /// </summary>
        [NotMapped]
        public string TiempoEmpresa
        {
            get
            {
                var hoy = DateTime.Today;
                var anios = hoy.Year - FechaInicio.Year;
                var meses = hoy.Month - FechaInicio.Month;

                if (hoy.Day < FechaInicio.Day)
                {
                    meses--;
                }

                if (meses < 0)
                {
                    anios--;
                    meses += 12;
                }

                if (anios < 0)
                {
                    anios = 0;
                    meses = 0;
                }

                return string.Format("{0} anios y {1} meses", anios, meses);
            }
        }

        /// <summary>
        /// AFP calculado segun configuracion
        /// </summary>
        [NotMapped]
        public decimal AFP
        {
            get
            {
                var p = CalculoNominaServicio.ObtenerParametros();
                return Math.Round(Salario * (p.PorcentajeAfp / 100m), 2);
            }
        }

        /// <summary>
        /// ARS calculado segun configuracion
        /// </summary>
        [NotMapped]
        public decimal ARS
        {
            get
            {
                var p = CalculoNominaServicio.ObtenerParametros();
                return Math.Round(Salario * (p.PorcentajeArs / 100m), 2);
            }
        }

        /// <summary>
        /// ISR calculado segun escala salarial configurada
        /// </summary>
        [NotMapped]
        public decimal ISR
        {
            get
            {
                var p = CalculoNominaServicio.ObtenerParametros();
                return CalculoNominaServicio.CalcularIsrMensual(Salario, p.EscalasIsr);
            }
        }

        public virtual ICollection<HistorialSalario> HistorialSalarios { get; set; }
        public virtual ICollection<Vacaciones> Vacaciones { get; set; }

    }
}
