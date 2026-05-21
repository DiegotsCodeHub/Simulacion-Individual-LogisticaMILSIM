using System;
using System.Collections.Generic;
using SimulacionMILSIM.Models;
using static SimulacionMILSIMVariables.Variables;
using SimulacionMILSIMGenerador;
using SimulacionMILSIMFunciones;

namespace SimulacionMILSIMSimulador
{
    public class Simulador
    {
        public List<ResultadoSimulacion> 
            EjecutarSimulacion(
            Inventario inventario,
            Escuadra escuadra,
            ConfigSim config)

        {
            List<ResultadoSimulacion> resultados = new List<ResultadoSimulacion>();

            Convoy convoy = new Convoy();

            double costoTotalAcumulado = 0;

            // ==========================
            // EVENTOS
            // =========================

            int NPseudo = 0;

            for (int hora = 1; hora <= config.HorasSimulacion; hora++)
            {
                bool convoyLlegado = false;

                // ======================
                // CONSUMO
                // ======================

                float rConsumoAmmo = Pseudo.Numeros[NPseudo];

                NPseudo = Funciones.SiguientePseudo(NPseudo);

                int consumo = escuadra.ConsumoMinimo + (int)(rConsumoAmmo * 
                    (escuadra.ConsumoMaximo - escuadra.ConsumoMinimo + 1));

                inventario.StockActual -= consumo;


                // ======================
                // EVENTO ALEATORIO
                // PERDIDA DE MUNICION
                // ======================

                float rPerdidaAmmo = Pseudo.Numeros[NPseudo];

                NPseudo = Funciones.SiguientePseudo(NPseudo);

                bool perdidaMunicion = false;

                if (rPerdidaAmmo < 0.05f)
                {
                    inventario.StockActual -= 15;

                    perdidaMunicion = true;
                }

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

                    // ======================
                    // POSIBLE RETRASO
                    // ======================

                    float rRetraso = Pseudo.Numeros[NPseudo];

                    NPseudo = Funciones.SiguientePseudo(NPseudo);

                    bool ConvoyRetrasado = false;

                    if (rRetraso < 0.10f)
                    {
                        convoy.HorasRestantes += 2;

                        ConvoyRetrasado = true;
                    }

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

                        // ======================
                        // TIEMPO
                        // ======================

                        float rConvoy = Pseudo.Numeros[NPseudo];

                        NPseudo = Funciones.SiguientePseudo(NPseudo);

                        convoy.HorasRestantes =  config.TiempoMinConvoy + 
                            (int)( rConvoy * ( config.TiempoMaxConvoy - config.TiempoMinConvoy + 1));

                        reorden = true;

                        costoConvoy = config.CostoConvoy;
                    }
                }

                // ==========================
                // COSTOS
                // ==========================

                double costoInventario = 
                    inventario.StockActual * config.CostoInventario;

                double costoFaltante = 
                    faltante * config.CostoFaltante;

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