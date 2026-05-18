using System;
using System.Collections.Generic;
using SimulacionMILSIM.Models;

namespace SimulacionMILSIM.Services
{
    public class Simulador
    {
        private Random rnd = new Random();

        // ==========================
        // COSTOS BASE
        // ==========================

        private const double COSTO_INVENTARIO = 0.5;

        private const double COSTO_FALTANTE = 5.0;

        private const double COSTO_CONVOY = 250.0;

        public List<ResultadoSimulacion> EjecutarSimulacion(
            Inventario inventario,
            Escuadra escuadra,
            int horas)
        {
            List<ResultadoSimulacion> resultados =
                new List<ResultadoSimulacion>();

            Convoy convoy = new Convoy();

            double costoTotalAcumulado = 0;

            for (int hora = 1; hora <= horas; hora++)
            {
                bool convoyLlegado = false;

                // ======================
                // CONSUMO
                // ======================

                int consumo = rnd.Next(
                    escuadra.ConsumoMinimo,
                    escuadra.ConsumoMaximo + 1);

                inventario.StockActual -= consumo;

                int faltante = 0;

                bool sinMunicion = false;

                if (inventario.StockActual < 0)
                {
                    faltante = Math.Abs(inventario.StockActual);

                    inventario.StockActual = 0;

                    sinMunicion = true;
                }

                bool reorden = false;

                // ======================
                // CONVOY EN CAMINO
                // ======================

                if (convoy.EnCamino)
                {
                    convoy.HorasRestantes--;

                    if (convoy.HorasRestantes <= 0)
                    {
                        inventario.StockActual +=
                            convoy.CantidadMunicion;

                        convoy.EnCamino = false;

                        convoyLlegado = true;
                    }
                }

                // ======================
                // SOLICITAR CONVOY
                // ======================

                double costoConvoy = 0;

                if (inventario.StockActual <=
                    inventario.PuntoReorden)
                {
                    if (!convoy.EnCamino)
                    {
                        convoy.EnCamino = true;

                        convoy.CantidadMunicion =
                            inventario.CantidadReabastecimiento;

                        convoy.HorasRestantes =
                            rnd.Next(2, 6);

                        reorden = true;

                        costoConvoy = COSTO_CONVOY;
                    }
                }

                // ==========================
                // COSTOS
                // ==========================

                double costoInventario =
                    inventario.StockActual *
                    COSTO_INVENTARIO;

                double costoFaltante =
                    faltante *
                    COSTO_FALTANTE;

                double costoTotal =
                    costoInventario +
                    costoFaltante +
                    costoConvoy;

                costoTotalAcumulado += costoTotal;


                // ======================
                // GUARDAR RESULTADOS
                // ======================

                resultados.Add(new ResultadoSimulacion
                {
                    Hora = hora,
                    Consumo = consumo,
                    StockRestante = inventario.StockActual,
                    ReabastecimientoSolicitado = reorden,
                    ConvoyEnCamino = convoy.EnCamino,
                    HorasRestantesConvoy = convoy.HorasRestantes,
                    ConvoyLlegado = convoyLlegado,
                    Faltante = faltante,
                    SinMunicion = sinMunicion,
                    CostoInventario = costoInventario,
                    CostoFaltante = costoFaltante,
                    CostoConvoy = costoConvoy,
                    CostoTotal = costoTotalAcumulado
                });
            }

            return resultados;
        }
    }
}