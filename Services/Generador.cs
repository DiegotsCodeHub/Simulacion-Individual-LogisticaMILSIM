using System.Collections.Generic;
using static SimulacionMILSIM.Variables;

namespace SimulacionMILSIM.Services
{
    public class pseudo
    {
        public float[] Numeros { get; set; }

        public pseudo()
        {
            Numeros = new float[325];
        }

        public void Generar(int A, int c, int Xo, int Mod, int Total)
        {
            Numeros = new float[Total];

            for (int i = 0; i < Total; i++)
            {
                Xo = (A * Xo + c) % Mod;
                Numeros[i] = Xo * 1f / Mod;
            }

            Encendido = true;
        }
    }
}