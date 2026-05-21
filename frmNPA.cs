using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimulacionMILSIM.Variables;
using MathNet.Numerics.Distributions;
using System.Windows.Forms.DataVisualization;

namespace SimulacionMILSIM
{
    public partial class frmNPA : Form
    {
        public frmNPA()
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

        private void cmdGenerar_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt32(txtA.Text);
            C = Convert.ToInt32(txtC.Text);
            Xo = Convert.ToInt32(txtXo.Text);
            Mod = Convert.ToInt32(txtM.Text);
            Total = Convert.ToInt32(txtTotal.Text);

            Pseudo.Generar(A, C, Xo, Mod, Total);

            dgvNumeros.Rows.Clear();

            if (Encendido == true)
            {
                Encender();
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdPrueba_Click(object sender, EventArgs e)
        {
            dgvPrueba.Rows.Clear();

            float Confianza = 0;

            float alfa = 0, Promedio = 0, Z = 0, Distribución = 0, Inferior = 0, Superior = 0;
            float Sumatorio = 0;

            // PRUEBA 1 -------------------------------------------------------------------------------------------------------------
            // Prueba de los Promedios, para confirmar si los datos están distribuidos uniformemente

            Confianza = Convert.ToSingle(txtGConfianza.Text);

            // Cálculo de alfa y Za/2

            alfa = (float)Math.Round(1 - Confianza, 6);
            Z = 1 - alfa / 2;

            // Cálculo del promedio

            for (int i = 0; i < Total; i++)
            {
                Sumatorio += Pseudo.Numeros[i];
            }

            Promedio = Sumatorio / Total;

            // Cálculo de la Inversa de la Distribución Normal

            System.Windows.Forms.DataVisualization.Charting.Chart Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            Distribución = (float)Math.Round(Chart1.DataManipulator.Statistics.InverseNormalDistribution(Z), 2);

            // Cálculo del límite inferior y superior

            Inferior = (float)(1 / 2f - Distribución * (1 / (1 * Math.Pow(12 * Total, 0.5f))));
            Superior = (float)(1 / 2f + Distribución * (1 / (1 * Math.Pow(12 * Total, 0.5f))));

            // Impresión de resultados

            txtAlfa.Text = alfa.ToString();
            txtPromedio.Text = Promedio.ToString();
            txtZa2.Text = Z.ToString();
            txtVDistribucion.Text = Distribución.ToString();
            txtLInferior.Text = Inferior.ToString();
            txtLSuperior.Text = Superior.ToString();

            if (Inferior <= Promedio && Promedio <= Superior)
            {
                lblDistribucion1.Text = "Están distribuidos uniformemente, listos para ser utilizados.";
            }
            else
            {
                lblDistribucion1.Text = "No están distribuidos uniformemente, utilice otros datos.";
            }

            // PRUEBA 2 -------------------------------------------------------------------------------------------------------------
            // Prueba de Poker

            float[,] Frecuencias = new float[5, 7];
            int P1, P2, P3, P4, P5;
            int N = 0;
            bool Continuar = true;

            string[] Nombres = new string[7];

            Nombres[0] = "Todos diferentes";
            Nombres[1] = "Un par";
            Nombres[2] = "Dos pares";
            Nombres[3] = "Una tercía";
            Nombres[4] = "Full";
            Nombres[5] = "Poker";
            Nombres[6] = "Quintilla";

            // Frecuencias

            Frecuencias[0, 0] = 0.30240f;
            Frecuencias[0, 1] = 0.50400f;
            Frecuencias[0, 2] = 0.10800f;
            Frecuencias[0, 3] = 0.07200f;
            Frecuencias[0, 4] = 0.00900f;
            Frecuencias[0, 5] = 0.00450f;
            Frecuencias[0, 6] = 0.00010f;

            // Comprobación de la Frecuencia Esperada

            for (int i = 0; i < 7; i++)
            {
                Frecuencias[2, i] = Total * Frecuencias[0, i];
            }

            // Obtención de la Frecuencia Observada

            for (int i = 0; i < Total; i++)
            {
                P1 = (int)Math.Floor(Pseudo.Numeros[i] * 10);
                P2 = (int)Math.Floor(Pseudo.Numeros[i] * 100 - P1 * 10);
                P3 = (int)Math.Floor(Pseudo.Numeros[i] * 1000 - P1 * 100 - P2 * 10);
                P4 = (int)Math.Floor(Pseudo.Numeros[i] * 10000 - P1 * 1000 - P2 * 100 - P3 * 10);
                P5 = (int)Math.Floor(Pseudo.Numeros[i] * 100000 - P1 * 10000 - P2 * 1000 - P3 * 100 - P4 * 10);

                // Aquí dentro se asegura de todas las posibles combinaciones para detectar que frecuencas se observan

                if (P1 == P2)
                {
                    if (P1 == P3)
                    {
                        if (P1 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 6]++;
                            }
                            else
                            {
                                Frecuencias[1, 5]++;
                            }
                        }
                        else
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 5]++;
                            }
                            else if (P4 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else
                            {
                                Frecuencias[1, 3]++;
                            }
                        }
                    }
                    else
                    {
                        if (P1 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 5]++;
                            }
                            else if (P3 == 5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else
                            {
                                Frecuencias[1, 3]++;
                            }
                        }
                        else if (P3 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else if (P3 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else
                            {
                                Frecuencias[1, 2]++;
                            }
                        }
                        else
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 3]++;
                            }
                            else if (P3 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else if (P4 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else
                            {
                                Frecuencias[1, 1]++;
                            }
                        }
                    }
                }
                else
                {
                    if (P1 == P3)
                    {
                        if (P1 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 5]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else
                            {
                                Frecuencias[1, 3]++;
                            }
                        }
                        else if (P2 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else
                            {
                                Frecuencias[1, 2]++;
                            }
                        }
                        else
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 3]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else if (P4 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else
                            {
                                Frecuencias[1, 1]++;
                            }
                        }
                    }
                    else if (P2 == P3)
                    {
                        if (P1 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else
                            {
                                Frecuencias[1, 2]++;
                            }
                        }
                        else if (P2 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 4]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 5]++;
                            }
                            else
                            {
                                Frecuencias[1, 3]++;
                            }
                        }
                        else
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 3]++;
                            }
                            else if (P4 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else
                            {
                                Frecuencias[1, 1]++;
                            }
                        }
                    }
                    else
                    {
                        if (P1 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 3]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else if (P3 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else
                            {
                                Frecuencias[1, 1]++;
                            }
                        }
                        else if (P2 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 3]++;
                            }
                            else if (P3 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else
                            {
                                Frecuencias[1, 1]++;
                            }
                        }
                        else if (P3 == P4)
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 2]++;
                            }
                            else if (P3 == P5)
                            {
                                Frecuencias[1, 3]++;
                            }
                            else
                            {
                                Frecuencias[1, 1]++;
                            }
                        }
                        else
                        {
                            if (P1 == P5)
                            {
                                Frecuencias[1, 1]++;
                            }
                            else if (P2 == P5)
                            {
                                Frecuencias[1, 1]++;
                            }
                            else if (P3 == P5)
                            {
                                Frecuencias[1, 1]++;
                            }
                            else if (P4 == P5)
                            {
                                Frecuencias[1, 1]++;
                            }
                            else
                            {
                                Frecuencias[1, 0]++;
                            }
                        }
                    }
                }
            }

            // Escritura de la Tabla

            for (int i = 0; i < 7; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvPrueba.Rows[0].Clone();

                row.Cells[0].Value = Nombres[i];
                row.Cells[1].Value = Frecuencias[1, i];
                row.Cells[2].Value = Frecuencias[2, i];
                dgvPrueba.Rows.Add(row);

                if (Total < 30)
                {
                    N++;
                    Frecuencias[3, i] = Frecuencias[1, i];
                    Frecuencias[4, i] += Frecuencias[2, i];
                }
                else
                {
                    if (Continuar == true)
                    {
                        if (Frecuencias[1, i] <= 3)
                        {
                            Continuar = false;
                            Frecuencias[3, N - 1] += Frecuencias[1, i];
                            Frecuencias[4, N - 1] += Frecuencias[2, i];
                        }
                        else
                        {
                            N++;
                            Frecuencias[3, i] = Frecuencias[1, i];
                            Frecuencias[4, i] += Frecuencias[2, i];
                        }
                    }
                    else
                    {
                        Frecuencias[3, N - 1] += Frecuencias[1, i];
                        Frecuencias[4, N - 1] += Frecuencias[2, i];
                    }
                }
            }

            float DistCalc = 0;
            for (int i = 0; i < N; i++)
            {
                DistCalc += (float)Math.Pow((Frecuencias[1, i] - Frecuencias[2, i]), 2) / Frecuencias[2, i];
            }


            // Distribución Uniforme

            float Distribucion2 = 0;

            Distribucion2 = (float)ChiSquared.InvCDF(N - 1, 1 - alfa);
            txtX2Tabla.Text = Distribucion2.ToString();
            txtX2Calc.Text = DistCalc.ToString();

            if (DistCalc < Distribucion2)
            {
                lblDistribucion2.Text = "Están distribuidos uniformemente, listos para ser utilizados.";
            }
            else
            {
                lblDistribucion2.Text = "No están distribuidos uniformemente, utilice otros datos.";
            }
        }


        private void Encender()
        {
            //Aquí se van generando uno por uno dentro de la función.

            dgvNumeros.Rows.Clear();
            dgvPrueba.Rows.Clear();

            for (int i = 0; i < Total; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgvNumeros.Rows[0].Clone();

                row.Cells[0].Value = i + 1;
                row.Cells[1].Value = Pseudo.Numeros[i];
                dgvNumeros.Rows.Add(row);
            }

            cmdPrueba.Enabled = true;
        }

    }
}
