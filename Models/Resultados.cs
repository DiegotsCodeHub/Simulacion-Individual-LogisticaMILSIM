namespace SimulacionMILSIM.Models
{
    public class ResultadoSimulacion
    {

        // =======================
        // PROPIEDADES
        // =======================
        public int Hora { get; set; }

        public int Consumo { get; set; }

        public int StockRestante { get; set; }

        public bool ReabastecimientoSolicitado { get; set; }

        // =======================
        // CONVOY LOGISTICO
        // =======================

        public bool ConvoyEnCamino { get; set; }

        public int HorasRestantesConvoy { get; set; }

        public bool ConvoyLlegado { get; set; }

        // =======================
        // FALTANTE DE MUNICION y COSTOS DE OPERACION
        // =======================

        public int Faltante { get; set; }

        public bool SinMunicion { get; set; }

        public double CostoInventario { get; set; }

        public double CostoFaltante { get; set; }

        public double CostoConvoy { get; set; }

        public double CostoTotal { get; set; }
    }
}