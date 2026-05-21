using System;
using System.Collections.Generic;
using System.Linq;

namespace SimulacionContaminacion.Services
{
    public class PruebaSmirnov
    {
        public string Evaluar(List<double> numeros)
        {
            List<double> copia = numeros.OrderBy(x => x).ToList();

            copia.Sort();

            int n = copia.Count;

            double dMax = 0;

            for (int i = 0; i < n; i++)
            {
                double fo = (double)(i + 1) / n;

                double fe = copia[i];

                double d = Math.Abs(fo - fe);

                if (d > dMax)
                    dMax = d;
            }

            // Valor crítico aproximado alpha 0.05

            double dCritico = 1.36 / Math.Sqrt(n);

            if (dMax < dCritico)
            {
                return $"PRUEBA KOLMOGOROV-SMIRNOV APROBADA\r\n" + $"\r\nDMax: {dMax:F4}";
            }
            else
            {
                return $"PRUEBA KOLMOGOROV-SMIRNOV RECHAZADA\r\n" + $"\r\nDMax: {dMax:F4}";
            }
        }
    }
}