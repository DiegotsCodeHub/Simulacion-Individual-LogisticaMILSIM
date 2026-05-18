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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {

            chartMunicion.Series.Clear();
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
                ConsumoMinimo = 50,
                ConsumoMaximo = 150
            };

            Simulador simulador = new Simulador();

            var resultados =
                simulador.EjecutarSimulacion(
                    inventario,
                    escuadra,
                    24);

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
        }








    }
}
