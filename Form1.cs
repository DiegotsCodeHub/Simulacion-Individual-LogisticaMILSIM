using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SimulacionMILSIM.Models;
using SimulacionMILSIM.Services;

namespace SimulacionMILSIM
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {

            chartMunicion.ResetAutoValues();
            lstEventos.Items.Clear();
            lstConvoy.Items.Clear();
            lstCostos.Items.Clear();
            lstFaltantes.Items.Clear();

            Inventario inventario = new Inventario
            {
                StockActual = (int)numInventario.Value,
                PuntoReorden = (int)numReorden.Value,
                CantidadReabastecimiento =
                    (int)numRestock.Value
            };

            Escuadra escuadra = new Escuadra
            {
                Nombre = "Alpha",
                ConsumoMinimo = (int)numConsumoMin.Value,
                ConsumoMaximo = (int)numConsumoMax.Value
            };

            ConfigSim config =
                new ConfigSim
                {
                    CostoInventario =
                    (double)numCostoInventario.Value,

                    CostoFaltante =
                    (double)numCostoFaltante.Value,

                    CostoConvoy =
                    (double)numCostoConvoy.Value,

                    TiempoMinConvoy =
                    (int)numTiempoMinConvoy.Value,

                    TiempoMaxConvoy =
                    (int)numTiempoMaxConvoy.Value,

                    HorasSimulacion =
                    (int)numHoras.Value
                };


            Simulador simulador = new Simulador();

            var resultados =
                simulador.EjecutarSimulacion(
                    inventario,
                    escuadra,
                    config);

            chartMunicion.Series.Clear();

            chartMunicion.Series.Add("Municion");

            foreach (var r in resultados)
            {
                lstEventos.Items.Add(
                    $"Hora {r.Hora} | " +
                    $"Consumo: {r.Consumo} | " +
                    $"Stock: {r.StockRestante}");


                if (r.ReabastecimientoSolicitado)
                {
                    lstConvoy.Items.Add(
                        $"Hora {r.Hora} | " +
                        ">>> CONVOY SOLICITADO");
                }


                if (r.ConvoyEnCamino)
                {
                    lstConvoy.Items.Add(
                        $"Hora {r.Hora} | " +
                        $"Convoy llega en " +
                        $"{r.HorasRestantesConvoy} horas");
                }

                if (r.ConvoyLlegado)
                {
                    lstConvoy.Items.Add(
                        $"Hora {r.Hora} | " +
                        ">>> CONVOY HA LLEGADO");
                }

                if (r.SinMunicion)
                {
                    lstFaltantes.Items.Add(
                        $"Hora {r.Hora} | " +
                        $"!!! FALTANTE: {r.Faltante} Municiones");
                }

                lstCostos.Items.Add(
                    $"Hora {r.Hora} | " +
                    $"Costo acumulado: $" +
                    $"{r.CostoTotal:F2}");

                chartMunicion.Series["Municion"]
                    .Points.AddXY(r.Hora, r.StockRestante);
            }

            int consumoTotal = resultados.Sum(r => r.Consumo);
            lblConsumoTotal.Text = "Consumo total de municiones: " + consumoTotal.ToString();

            int faltantesTotales = resultados.Sum(r => r.Faltante);
            lblFaltantesTotales.Text = "Municiones faltantes: " + faltantesTotales.ToString();

            double costoTotal = resultados.Last().CostoTotal;
            lblCostoTotal.Text = "Costo total de la operacion: " + costoTotal.ToString("F2");

            int convoyes = resultados.Count(r => r.ReabastecimientoSolicitado);
            lblConvoyes.Text = "Cantidad de Convoys enviados: " + convoyes.ToString();

            int horasSinMunicion = resultados.Count(r => r.SinMunicion);
            lblHorasSinMunicion.Text = "Horas de combate sin municion: " + horasSinMunicion.ToString();

            double eficiencia = (1.0 - ((double)faltantesTotales / consumoTotal)) * 100;
            lblEficiencia.Text = "Eficiencia general de la logistica: " + eficiencia.ToString("F2") + "%";


        }








    }
}
