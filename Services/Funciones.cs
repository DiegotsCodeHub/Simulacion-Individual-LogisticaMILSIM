using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimulacionMILSIMVariables.Variables;

namespace SimulacionMILSIMFunciones
{
    class Funciones
    {
        public static void Generados()
        {
            Encendido = true;
        }

        public static int SiguientePseudo(int NPseudo)
        {
            NPseudo++;

            if (NPseudo == Total)
            {
                NPseudo = 0;
            }

            return NPseudo;
        }


    }
}
