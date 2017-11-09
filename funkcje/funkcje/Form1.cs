using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace funkcje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double liczba;

        double liniowa(double a, double b, double x)
        {
            return (a * x + b);
        }

        private void generuj_Click(object sender, EventArgs e)
        {
            liczba = double.Parse(wzor.Text);
            wzor.Text = (Math.Pow(liczba,2)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Wykres.ChartAreas[0].AxisY.ScaleView.Zoom(-15 , 15); // powiększenie Y
            //Wykres.ChartAreas[0].AxisX.ScaleView.Zoom(-15 , 15);  // powiększenie X
            //Wykres.ChartAreas[0].CursorX.IsUserEnabled = true;
            //Wykres.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            //Wykres.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            for (int i = -15; i <= 15; i++)
            {
                Wykres.Series[0].Points.AddXY(i,liniowa(2, 4, i));
                //Wykres.Series[1].Points.AddXY(i, liniowa(5, 2, i));
            }
            for (int i = -15; i <= 15; i++)
            {
                Wykres.Series[0].Points.AddXY(i, liniowa(7, 5, i));
                //Wykres.Series[1].Points.AddXY(i, liniowa(5, 2, i));
            }

        }

        
    }
}
