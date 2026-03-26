using System;
using System.Collections.Generic;

namespace SiManEm.Configuracion
{
    public static class NominaConfiguracion
    {
        // Porcentajes configurables
        public const decimal PorcentajeAfp = 0.0304m;
        public const decimal PorcentajeArs = 0.0304m;

        // Escala ISR anual (RD) configurable
        public static readonly List<EscalaIsr> EscalasIsrAnual = new List<EscalaIsr>
        {
            new EscalaIsr
            {
                LimiteInferior = 0m,
                LimiteSuperior = 416220.00m,
                Tasa = 0m,
                CuotaFija = 0m
            },
            new EscalaIsr
            {
                LimiteInferior = 416220.00m,
                LimiteSuperior = 624329.00m,
                Tasa = 0.15m,
                CuotaFija = 0m
            },
            new EscalaIsr
            {
                LimiteInferior = 624329.00m,
                LimiteSuperior = 867123.00m,
                Tasa = 0.20m,
                CuotaFija = 31216.00m
            },
            new EscalaIsr
            {
                LimiteInferior = 867123.00m,
                LimiteSuperior = decimal.MaxValue,
                Tasa = 0.25m,
                CuotaFija = 79764.00m
            }
        };

        public static decimal CalcularIsrMensual(decimal salarioMensual)
        {
            var salarioAnual = salarioMensual * 12m;
            var impuestoAnual = 0m;

            foreach (var escala in EscalasIsrAnual)
            {
                if (salarioAnual > escala.LimiteInferior && salarioAnual <= escala.LimiteSuperior)
                {
                    impuestoAnual = escala.CuotaFija + ((salarioAnual - escala.LimiteInferior) * escala.Tasa);
                    break;
                }
            }

            return Math.Round(impuestoAnual / 12m, 2);
        }
    }

    public class EscalaIsr
    {
        public decimal LimiteInferior { get; set; }
        public decimal LimiteSuperior { get; set; }
        public decimal Tasa { get; set; }
        public decimal CuotaFija { get; set; }
    }
}
