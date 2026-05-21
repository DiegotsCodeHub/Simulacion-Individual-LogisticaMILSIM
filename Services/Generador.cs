using System.Collections.Generic;

namespace SimulacionContaminacion.Services
{
    public class GeneradorCongruencial
    {
        private long semilla;
        private long a;
        private long c;
        private long m;

        public GeneradorCongruencial(
            long semilla = 17,
            long a = 101,
            long c = 221,
            long m = 17001)
        {
            this.semilla = semilla;
            this.a = a;
            this.c = c;
            this.m = m;
        }

        public List<double> GenerarNumeros(int cantidad)
        {
            List<double> numeros = new List<double>();

            long X = semilla;

            for (int i = 0; i < cantidad; i++)
            {
                X = (a * X + c) % m;

                double ri = (double)X / m;

                numeros.Add(ri);
            }

            return numeros;
        }
    }
}