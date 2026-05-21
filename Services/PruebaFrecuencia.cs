using System;
using System.Collections.Generic;

namespace SimulacionContaminacion.Services
{
    public class PruebaFrecuencia
    {
        public string Evaluar(List<double> numeros)
        {
            int intervalos = 10;

            int[] frecuencias = new int[intervalos];

            foreach (double num in numeros)
            {
                int indice = (int)(num * intervalos);

                if (indice == intervalos)
                    indice--;

                frecuencias[indice]++;
            }

            double esperado =
                (double)numeros.Count / intervalos;

            double chi = 0;

            for (int i = 0; i < intervalos; i++)
            {
                chi += Math.Pow(
                    frecuencias[i] - esperado, 2)
                    / esperado;
            }

            // Valor crítico aproximado para:
            // alpha = 0.05
            // gl = 9

            double chiCritico = 16.919;

            if (chi < chiCritico)
            {
                return $"PRUEBA DE FRECUENCIA APROBADA\r\n" + $"\r\nChi calculado: {chi:F4}";
            }
            else
            {
                return $"PRUEBA DE FRECUENCIA RECHAZADA\r\n" + $"\r\nChi calculado: {chi:F4}";
            }
        }
    }
}