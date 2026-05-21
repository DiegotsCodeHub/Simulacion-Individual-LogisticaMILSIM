using SimulacionMILSIM.Models;
using SimulacionMILSIMSimulador;
using static SimulacionMILSIMVariables.Variables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionMILSIM
{
    public partial class Form1: Form
    {
      
        List<double> numerosGenerados = new List<double>();

        public Form1()
        {
            InitializeComponent();
            
            if (Encendido == true)
            {
                Encender();

                txtA.Text = A.ToString();
                txtC.Text = C.ToString();
                txtXo.Text = Xo.ToString();
                txtM.Text = Mod.ToString();
                txtTotal.Text = Total.ToString();
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {

            if (!Encendido)
            {
                MessageBox.Show(
                    "Primero debes generar números pseudoaleatorios.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            chartMunicion.ResetAutoValues();
            lstEventos.Items.Clear();
            lstConvoy.Items.Clear();
            lstCostos.Items.Clear();
            lstFaltantes.Items.Clear();

            Inventario inventario = new Inventario
            {
                StockActual = (int)numInventario.Value,
                PuntoReorden = (int)numReorden.Value,
                CantidadReabastecimiento = (int)numRestock.Value
            };

            Escuadra escuadra = new Escuadra
            {
                Nombre = "Alpha",
            };

            switch (cmbIntensidadCombate.Text)
            {
                case "Baja":
                    escuadra.ConsumoMinimo = 50;
                    escuadra.ConsumoMaximo = 150;
                    break;

                case "Media":
                    escuadra.ConsumoMinimo = 150;
                    escuadra.ConsumoMaximo = 350;
                    break;

                case "Alta":
                    escuadra.ConsumoMinimo = 350;
                    escuadra.ConsumoMaximo = 700;
                    break;

                default:
                    escuadra.ConsumoMinimo = 50;
                    escuadra.ConsumoMaximo = 150;
                    break;
            }

            ConfigSim config =
                new ConfigSim
                {
                    CostoInventario = (double)numCostoInventario.Value,

                    CostoFaltante = (double)numCostoFaltante.Value,

                    CostoConvoy = (double)numCostoConvoy.Value,

                    HorasSimulacion = (int)numHoras.Value,
                };

            switch (cmbConvoyRiesgo.Text)
            {
                case "Bajo":

                    config.TiempoMinConvoy = 1;
                    config.TiempoMaxConvoy = 3;

                    break;

                case "Medio":

                    config.TiempoMinConvoy = 2;
                    config.TiempoMaxConvoy = 6;

                    break;

                case "Alto":

                    config.TiempoMinConvoy = 4;
                    config.TiempoMaxConvoy = 10;

                    break;

                default:

                    config.TiempoMinConvoy = 2;
                    config.TiempoMaxConvoy = 5;

                    break;
            }


            Simulador simulador = new Simulador();

            var resultados =
                simulador.EjecutarSimulacion(
                    inventario,
                    escuadra,
                    config);

            chartMunicion.Series.Clear();

            // =======================
            // GRAFICA MUNICIÓN
            // =======================

            chartMunicion.Series.Add("Municion");

            chartMunicion.Series["Municion"].ChartType =
                System.Windows.Forms.DataVisualization.Charting
                .SeriesChartType.Column;

            chartMunicion.Series["Municion"].Color =
                Color.DodgerBlue;

            // =======================
            // GRAFICA FALTANTES
            // =======================

            chartMunicion.Series.Add("Faltantes");

            chartMunicion.Series["Faltantes"].ChartType =
                System.Windows.Forms.DataVisualization.Charting
                .SeriesChartType.Column;

            chartMunicion.Series["Faltantes"].Color =
                Color.Red;

            // =======================
            // GRAFICA COSTOS
            // =======================

            chartMunicion.Series.Add("Costos");

            chartMunicion.Series["Costos"].ChartType =
                System.Windows.Forms.DataVisualization.Charting
                .SeriesChartType.Line;

            chartMunicion.Series["Costos"].BorderWidth = 3;

            chartMunicion.Series["Costos"].Color =
                Color.LimeGreen;

            // =======================
            // GRAFICA CONSUMO
            // =======================

            chartMunicion.Series.Add("Consumo");

            chartMunicion.Series["Consumo"].ChartType =
                System.Windows.Forms.DataVisualization.Charting
                .SeriesChartType.Line;

            chartMunicion.Series["Consumo"].BorderWidth = 3;

            chartMunicion.Series["Consumo"].Color =
                Color.Orange;

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


                // =======================
                // GRAFICA RESULTADOS MUNICIÓN
                // =======================

                chartMunicion.Series["Municion"]
                    .Points.AddXY(
                        r.Hora,
                        r.StockRestante);

                // =======================
                // GRAFICA RESULTADOS FALTANTES
                // =======================

                chartMunicion.Series["Faltantes"]
                    .Points.AddXY(
                        r.Hora,
                        r.Faltante);

                // =======================
                //  GRAFICA RESULTADOS OSTOS
                // =======================

                chartMunicion.Series["Costos"]
                    .Points.AddXY(
                        r.Hora,
                        r.CostoTotal);

                // =======================
                // GRAFICA RESULTADOS CONSUMO
                // =======================

                chartMunicion.Series["Consumo"]
                    .Points.AddXY(
                        r.Hora,
                        r.Consumo);
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

        private void btnNumPseudo_Click(object sender, EventArgs e)
        {
            frmNPA FormaPsuedo = new frmNPA();

            btnNumPseudo.Enabled = false;
            DialogResult Accion = FormaPsuedo.ShowDialog();
            if (Accion == DialogResult.Cancel)
            {
                btnNumPseudo.Enabled = true;
            }
        }

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt32(txtA.Text);
            C = Convert.ToInt32(txtC.Text);
            Xo = Convert.ToInt32(txtXo.Text);
            Mod = Convert.ToInt32(txtM.Text);

            int eventos = 4;

            if (cmbConvoyRiesgo.Text == "Alto")
            {
                eventos++;
            }

            if (cmbIntensidadCombate.Text == "Alta")
            {
                eventos++;
            }

            Total = ((int)numHoras.Value * eventos) + 50;
            txtTotal.Text = Total.ToString();

            Pseudo.Generar(A, C, Xo, Mod, Total);

            dgvNumeros.Rows.Clear();

            if (Encendido == true)
            {
                Encender();
            }
        }

        private void Encender()
        {
            // Esta es la función donde se imprimen

            dgvNumeros.Rows.Clear();

            for (int i = 0; i < Total; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvNumeros.Rows[0].Clone();

                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = Pseudo.Numeros[i];
                dgvNumeros.Rows.Add(row);

                numerosGenerados.Add(Pseudo.Numeros[i]);
            }

            btnSimular.Enabled = true;
        }
    }
}
