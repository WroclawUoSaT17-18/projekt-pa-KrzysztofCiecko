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

        }

        double liniowa(double a, double b, double x)
        {
            return (a * x + b);
        }

        static int nr_serii;
        private void rysuj_Click(object sender, EventArgs e)
        {
            
            double a, b;
            double x_1, x_2;
            if (Double.TryParse(a_lin_tb.Text, out a))
                a = double.Parse(a_lin_tb.Text);
            else
            {
                MessageBox.Show("Błędny format danej a", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Double.TryParse(b_lin_tb.Text, out b))
                b = double.Parse(b_lin_tb.Text);
            else
            {
                MessageBox.Show("Błędny format danej b" ,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (Double.TryParse(x_min.Text, out x_1))
                x_1 = double.Parse(x_min.Text);
            else
            {
                MessageBox.Show("Błędny format danej min.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (Double.TryParse(x_max.Text, out x_2))
                x_2 = double.Parse(x_max.Text);
            else
            {
                MessageBox.Show("Błędny format danej max.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            wykres.Series.Add(new Series("liniowa " + nr_serii.ToString() ) );
            wykres.Series[nr_serii].ChartType = SeriesChartType.Line;
            wykres.Series[nr_serii].BorderWidth = 2;

            for (double i = x_1; i <= x_2; i += 0.1)
            {
                wykres.Series[nr_serii].Points.AddXY(i, liniowa(a, b, i));
            }
            nr_serii++;
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

        



    }
}
