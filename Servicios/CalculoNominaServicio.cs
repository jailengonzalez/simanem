using System;
using System.Collections.Generic;
using System.Linq;
using SiManEm.Datos;
using SiManEm.Modelos;

namespace SiManEm.Servicios
{
    public class ParametrosNomina
    {
        public decimal PorcentajeAfp { get; set; }
        public decimal PorcentajeArs { get; set; }
        public List<EscalaIsr> EscalasIsr { get; set; }
    }

    public static class CalculoNominaServicio
    {
        private static readonly object Bloqueo = new object();
        private static DateTime _ultimaLectura = DateTime.MinValue;
        private static ParametrosNomina _cache;

        public static ParametrosNomina ObtenerParametros()
        {
            lock (Bloqueo)
            {
                if (_cache != null && (DateTime.Now - _ultimaLectura).TotalSeconds < 30)
                {
                    return _cache;
                }

                try
                {
                    using (var db = new SiManEmContexto())
                    {
                        var config = db.ConfiguracionesNomina.FirstOrDefault();
                        var escalas = db.EscalasIsr.OrderBy(x => x.LimiteInferior).ToList();

                        if (config == null || escalas.Count == 0)
                        {
                            _cache = CrearParametrosPorDefecto();
                        }
                        else
                        {
                            _cache = new ParametrosNomina
                            {
                                PorcentajeAfp = config.PorcentajeAfp,
                                PorcentajeArs = config.PorcentajeArs,
                                EscalasIsr = escalas
                            };
                        }
                    }
                }
                catch
                {
                    _cache = CrearParametrosPorDefecto();
                }

                _ultimaLectura = DateTime.Now;
                return _cache;
            }
        }

        public static decimal CalcularIsrMensual(decimal salarioMensual, List<EscalaIsr> escalas)
        {
            var salarioAnual = salarioMensual * 12m;
            var impuestoAnual = 0m;

            foreach (var escala in escalas.OrderBy(x => x.LimiteInferior))
            {
                if (salarioAnual > escala.LimiteInferior && salarioAnual <= escala.LimiteSuperior)
                {
                    impuestoAnual = escala.CuotaFija + ((salarioAnual - escala.LimiteInferior) * escala.Tasa);
                    break;
                }
            }

            return Math.Round(impuestoAnual / 12m, 2);
        }

        private static ParametrosNomina CrearParametrosPorDefecto()
        {
            return new ParametrosNomina
            {
                PorcentajeAfp = 3.04m,
                PorcentajeArs = 3.04m,
                EscalasIsr = new List<EscalaIsr>
                {
                    new EscalaIsr { LimiteInferior = 0m, LimiteSuperior = 416220.00m, Tasa = 0m, CuotaFija = 0m },
                    new EscalaIsr { LimiteInferior = 416220.00m, LimiteSuperior = 624329.00m, Tasa = 0.15m, CuotaFija = 0m },
                    new EscalaIsr { LimiteInferior = 624329.00m, LimiteSuperior = 867123.00m, Tasa = 0.20m, CuotaFija = 31216.00m },
                    new EscalaIsr { LimiteInferior = 867123.00m, LimiteSuperior = decimal.MaxValue, Tasa = 0.25m, CuotaFija = 79764.00m }
                }
            };
        }
    }
}
