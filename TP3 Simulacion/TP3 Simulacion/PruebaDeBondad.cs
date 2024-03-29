﻿using BibliotecaTP3SIM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_Simulacion
{
    public partial class PruebaDeBondad : Form
    {
        public PruebaDeBondad()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbUniforme_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUniforme.Checked)
            {
                grpUniforme.Enabled = true;
            }
            else
            {
                grpUniforme.Enabled = false;
            }
        }

        private void rdNormal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdPoisson_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPoisson.Checked)
            {
                txtLambda.Enabled = true;
                lblLambda.Enabled = true;
                txtN.Enabled = false;
                Muestra.Enabled = false;
            }
            else
            {
                txtN.Enabled = true;
                Muestra.Enabled = true;
                txtLambda.Enabled = false;
                lblLambda.Enabled = false;
            }
        }

        private void rdExponencialNegativa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdExponencialNegativa.Checked)
            {
                txtMedia.Enabled = true;
                lblMedia.Enabled = true;
            }
            else
            {
                txtMedia.Enabled = false;
                lblMedia.Enabled = false;
            }
        }

        

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarVariablesAleatorias Metodos = new GenerarVariablesAleatorias();
            List<double> list = new List<double>();
            int N = Convert.ToInt32(txtN.Text);
            

            // Distribucion Uniforme
            if (rbUniforme.Checked)
            {
                int min = Convert.ToInt32(txtMin.Text);
                int max = Convert.ToInt32(txtMax.Text);

                list = Metodos.SerieDisUniforme(N, min, max);               
            }

            // Distribucion Exponencial Negativa
            if (rdExponencialNegativa.Checked)
            {
                double Media = Convert.ToDouble(txtMedia.Text);

                list = Metodos.SerieExpNeg(N, Media);
            }

            // Distribucion Normal
            if (rdNormal.Checked)
            {
                list = Metodos.SerieDisNormal(N);
            }

            // Distribucion Poisson
            if (rdPoisson.Checked)
            {
                double lambda = Convert.ToDouble(txtLambda.Text);
                list = Metodos.SerieDisPoisson(lambda);
            }

            // Agregar valores a la lista
            foreach (var item in list)
            {
                lstNumeros.Items.Add(Math.Round(item,4));
            }

            // Prueba de bondad
            try
            {
                if (txtCantidadIntervalos.Text.Equals(""))
                {
                    MessageBox.Show("debe completar todos los campos");
                }
                else
                {
                    double[] extremos = CalcularExtremos(list);
                    double valorMin = Math.Round(extremos[0],4) ;
                    double valorMax = Math.Round(extremos[1],4);
                    double Prueba = 0;
                    double ancho = Math.Round((valorMax - valorMin) / Convert.ToDouble(txtCantidadIntervalos.Text),4);

                    int FreqEs = 0;

                    for (int i = 0; i < Convert.ToInt32(txtCantidadIntervalos.Text); i++)
                    {

                        int contador = 0;

                        DataGridViewRow fila = new DataGridViewRow();


                        // celda intervalo
                        DataGridViewTextBoxCell celdaIntervalo = new DataGridViewTextBoxCell();


                        if (i == 0)
                        {
                            valorMax = valorMin + ancho;

                            foreach (double item in lstNumeros.Items)
                            {
                                if (item > valorMin && item < valorMax)
                                {
                                    contador = contador + 1;
                                }

                            }
                            celdaIntervalo.Value = valorMin + " - " + valorMax;
                            fila.Cells.Add(celdaIntervalo);

                        }
                        else
                        {
                            valorMin = valorMin + ancho;
                            valorMax = valorMax + ancho;
                            foreach (double item in lstNumeros.Items)
                            {
                                if (item > valorMin && item < valorMax)
                                {
                                    contador = contador + 1;
                                }
                            }
                            celdaIntervalo.Value = valorMin + " - " + valorMax;
                            fila.Cells.Add(celdaIntervalo);
                        }


                        //// Celda Fo
                        DataGridViewTextBoxCell celdaFo = new DataGridViewTextBoxCell();
                        Convert.ToString(contador);
                        celdaFo.Value = contador;
                        fila.Cells.Add(celdaFo);

                        //// celda Fe
                        //DataGridViewTextBoxCell celdaFe = new DataGridViewTextBoxCell();
                        //celdaFe.Value = Convert.ToDecimal(TxtTamañoMuestra.Text) / Convert.ToDecimal(TxtCantidadIntervalos.Text);
                        //fila.Cells.Add(celdaFe);

                        //DataGridViewTextBoxCell celdaC = new DataGridViewTextBoxCell();
                        //double Fe = Convert.ToDouble(TxtTamañoMuestra.Text) / Convert.ToDouble(TxtCantidadIntervalos.Text);
                        //double Fo = Convert.ToDouble(contador);
                        //double resta = Fo - Fe;
                        //double c = Math.Pow(resta, 2) / Fe;
                        //celdaC.Value = c;
                        //fila.Cells.Add(celdaC);

                        //DataGridViewTextBoxCell celdaCacum = new DataGridViewTextBoxCell();
                        //if (i == 0)
                        //{
                        //    acumulador = c;
                        //}
                        //else
                        //{
                        //    acumulador = acumulador + c;
                        //}
                        //celdaCacum.Value = acumulador;
                        //fila.Cells.Add(celdaCacum);

                        //AgregarFila
                        grillaDatos.Rows.Add(fila);

                        //// Grafico
                        //string intervalo = Convert.ToString(valorMin) + "-" + Convert.ToString(valorMax);
                        //Series serieGR = chr.Series.Add(intervalo);
                        //serieGR.Points.AddXY("intervalos", contador);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("debe limpiar los campos");
            }
        }

        public double[] CalcularExtremos(List<double> lista)
        {
            double ValorMin = 0;
            double ValorMax = 0;
            int contador = 0;

            foreach (var item in lista)
            {
                contador++;
                if (contador == 1)
                {
                    ValorMax = item;
                    ValorMin = item;
                }
                else
                {
                    if (item > ValorMax)
                    {
                        ValorMax = item;
                    }
                    if (item < ValorMin)
                    {
                        ValorMin = item;
                    }
                }
            }

            double[] listaNumeros = new double[2];
            listaNumeros[0] = ValorMin;
            listaNumeros[1] = ValorMax;

            return listaNumeros;
        }
    }
}
