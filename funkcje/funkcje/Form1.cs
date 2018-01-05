using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace funkcje
{
    public partial class funkcje : Form
    {
        public funkcje()
        {
            InitializeComponent();
        }


        private void funkcje_Load(object sender, EventArgs e)
        {
            wykres.Series.Clear();
            /*
            wykres.Series.Add(new Series(" "));
            wykres.Series[0].ChartType = SeriesChartType.Line;
            wykres.Series[0].BorderWidth = 0;
            wykres.ChartAreas[0].AxisX.Minimum = 0;
            wykres.ChartAreas[0].AxisX.Maximum = 10;
            wykres.ChartAreas[0].AxisX.Title = "x";
            wykres.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            wykres.ChartAreas[0].AxisY.Title = "y";
            wykres.ChartAreas[0].AxisY.Minimum = 0;
            wykres.ChartAreas[0].AxisY.Maximum = 10;
            for (double i = 0; i <= 10; i += 0.1)
                wykres.Series[0].Points.AddXY(i, 0);
           */

        }

        double liniowa(double a, double b, double x)
        {
            return (a * x + b);
        }

        double kwadratowa(double a, double b, double c, double x)
        {
            return (a * x * x + b * x + c);
        }

        double sinusf(double A, double b, double c, double x) // A*sin(bx) + c
        {
            return ((A * Math.Sin(b * x )) +c);
        }

        double a, b, c, A; // parametry funkcji
        double x_1, x_2;   // zakres osi OX
        static int nr_serii;



        private void rysuj_Click(object sender, EventArgs e)
        {
            //if(nr_serii==0)wykres.Series.RemoveAt(0);
            if (dane_wejsciowe())
            {
                rysuj_funkcje();
                nr_serii++;
            }
            else
                return;
            
        }
        
        private void usun_but_Click(object sender, EventArgs e)
        {
            int i = int.Parse(usun_serie.Text);
            if (i>=0 && i<nr_serii)
            {
                wykres.Series.RemoveAt(i);
                nr_serii--; 
            }
            else
            {
                MessageBox.Show("Błędny numer serii");
            } 
            
        }

        void rysuj_funkcje()
        {
            if (liniowa_radiob.Checked == true)
                wykres.Series.Add(new Series("liniowa " + nr_serii.ToString()));

            if (kwadratowa_radiob.Checked == true)
                wykres.Series.Add(new Series("kwadratowa " + nr_serii.ToString()));

            if (sinus.Checked == true)
                wykres.Series.Add(new Series("sinus " + nr_serii.ToString()));

            wykres.Series[nr_serii].ChartType = SeriesChartType.Line; // typ wykresu
            wykres.Series[nr_serii].BorderWidth = 2;   // szerokość lini wykresu

            for (double i = x_1; i <= x_2; i += 0.1)
            {
                if (liniowa_radiob.Checked == true)
                    wykres.Series[nr_serii].Points.AddXY(i, liniowa(a, b, i));
                if (kwadratowa_radiob.Checked == true)
                    wykres.Series[nr_serii].Points.AddXY(i, kwadratowa(a, b, c, i));
                if (sinus.Checked == true)
                    wykres.Series[nr_serii].Points.AddXY(i, sinusf(A, b, c, i));
                

            }
        }

        bool dane_wejsciowe()
        {
            bool poprawne=true;
            if (Double.TryParse(a_lin_tb.Text, out a) && Double.TryParse(b_lin_tb.Text, out b) &&
                Double.TryParse(x_min.Text, out x_1)  && Double.TryParse(x_max.Text, out x_2) && 
                Double.TryParse(c_tb.Text, out c)     && Double.TryParse(Ampl_tb.Text, out A))
            {
                a = double.Parse(a_lin_tb.Text);
                b = double.Parse(b_lin_tb.Text);
                c = double.Parse(c_tb.Text);
                x_1 = double.Parse(x_min.Text);
                x_2 = double.Parse(x_max.Text);
                A = double.Parse(Ampl_tb.Text);
                return poprawne;
            }
            else
            {
                poprawne = false;
                MessageBox.Show("Błędny format danej", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return poprawne;
            }
            /*   
            else
            {
                MessageBox.Show("Błędny format danej a", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;// poprawne;
            }

            if (Double.TryParse(b_lin_tb.Text, out b))
                b = double.Parse(b_lin_tb.Text);
            else
            {
                MessageBox.Show("Błędny format danej b", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Double.TryParse(x_min.Text, out x_1))
                x_1 = double.Parse(x_min.Text);
            else
            {
                MessageBox.Show("Błędny format danej min.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Double.TryParse(x_max.Text, out x_2))
                x_2 = double.Parse(x_max.Text);
            else
            {
                MessageBox.Show("Błędny format danej max.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Double.TryParse(c_tb.Text, out c))
                c = double.Parse(c_tb.Text);
            else
            {
                MessageBox.Show("Błędny format danej c", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Double.TryParse(Ampl_tb.Text, out A))
                A = double.Parse(Ampl_tb.Text);
            else
            {
                MessageBox.Show("Błędny format danej A", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
        }

    }
}
