using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionMILSIM.Models
{
    public class ConfigSim
    {
        // COSTOS
        public double CostoInventario { get; set; }

        public double CostoFaltante { get; set; }

        public double CostoConvoy { get; set; }

        // CONVOY
        public int TiempoMinConvoy { get; set; }

        public int TiempoMaxConvoy { get; set; }

        // SIMULACIÓN
        public int HorasSimulacion { get; set; }

    }
}
