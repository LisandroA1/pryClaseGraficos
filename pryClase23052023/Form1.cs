using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pryClase23052023
{
    public partial class Form1 : Form
    {
        string[] alumnos = { "Ana", "Pedro", "Estela", "Luisa", "Jorge" };
        int[] notas1 = { 7, 3, 5, 8, 10 };
        int[] notas2 = { 5, 7, 2, 4, 1 };

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            chtGrafico.Series.Clear();
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            
            //CREO LA SERIE
            Series serie = chtGrafico.Series.Add("PRIMER PARCIAL");

            serie.Points.AddXY("ANA", 9);
            serie.Points.AddXY("PEDRO", 10);
            serie.Points.AddXY("DELFINA", 5);

            //AGREGAR PUNTOS A SERIE
            //serie.Points.Add(50);
            //serie.Points.Add(75);

            //OTRA FORMA DE HACERLO AL AGREGAR PUNTOS A LA SERIE
            //chtGrafico.Series[0].Points.Add(50);
            //chtGrafico.Series[0].Points.Add(75);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdAgregarcnVector_Click(object sender, EventArgs e)
        {
            //limpio el grafico
            chtGrafico.Series.Clear();
            
            //creo serie
            Series serie = chtGrafico.Series.Add("PRIMER PARCIAL");
            
            ////cambio la forma del grafico
            //serie.ChartType = SeriesChartType.Bar;
            
            //creo indice para recorrer
            int i = 0;
            
            //estructura repetitiva
            while (i < alumnos.Length)
            {
                serie.Points.AddXY(alumnos[i], notas1[i]);
                i++;
            }

            //Pongo titulo al grafico
            chtGrafico.Titles.Clear();
            chtGrafico.Titles.Add("LABORATORIO DE PROGRAMACION 3");

            //Pongo titulo a las X e Y
            chtGrafico.ChartAreas[0].AxisX.Title = "ALUMNOS";
            chtGrafico.ChartAreas[0].AxisY.Title = "NOTAS";     

        }

        private void cmdAgregarConDosVectores_Click(object sender, EventArgs e)
        {
            //limpio el grafico
            chtGrafico.Series.Clear();

            //creo serie
            Series serie1 = chtGrafico.Series.Add("PRIMER PARCIAL");
            Series serie2 = chtGrafico.Series.Add("SEGUNDO PARCIAL");

            ////cambio la forma del grafico
            //serie2.ChartType = SeriesChartType.Bar;

            //creo indice para recorrer
            int i = 0;

            //estructura repetitiva
            while (i < alumnos.Length)
            {
                serie1.Points.AddXY(alumnos[i], notas1[i]);
                serie2.Points.AddXY(alumnos[i], notas2[i]);
                i++;
            }

            //Pongo titulo al grafico
            chtGrafico.Titles.Clear();
            chtGrafico.Titles.Add("LABORATORIO DE PROGRAMACION 3");

            //Pongo titulo a las X e Y
            chtGrafico.ChartAreas[0].AxisX.Title = "ALUMNOS";
            chtGrafico.ChartAreas[0].AxisY.Title = "NOTAS";
        }
    }
}
