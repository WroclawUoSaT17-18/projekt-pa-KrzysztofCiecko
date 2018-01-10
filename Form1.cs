using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections.ObjectModel;

namespace funkcje_apl
{
    public partial class funkcje : Form
    {
        public funkcje()
        {
            InitializeComponent();
        }

        private void funkcje_Load(object sender, EventArgs e)
        {
            Form1.Series.Clear();
            Form1.ChartAreas[0].AxisX.Title = "x";
            Form1.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Far;
            Form1.ChartAreas[0].AxisY.Title = "y";
            Form1.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Far;
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
            return ((A * Math.Sin(b * x)) + c);
        }

        //////////////////////////////////////////////////////////
        double a, b, c; // parametry funkcji
        double x_1, x_2;   // zakres osi OX
        static int nr_serii;
        string do_zapisu;
        private void rysuj_Click(object sender, EventArgs e)
        {
            if (nr_serii > 10000)
            {
                MessageBox.Show("Maksymalna ilość serii to 6", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
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

            try
            {
                Form1.Series.RemoveAt(Form1.Series.IndexOf(usun_serie.Text));
                nr_serii--;
            }
            catch
            {
                MessageBox.Show("Błędna nazwa!");
            }



        }

        void rysuj_funkcje()
        {
                try
                {
                    if (liniowa_radiob.Checked == true)
                        Form1.Series.Add(new Series(nazwa_funkcji_tb.Text));
                
                    if (kwadratowa_radiob.Checked == true)
                        Form1.Series.Add(new Series(nazwa_funkcji_tb.Text));

                    if (sinus.Checked == true)
                        Form1.Series.Add(new Series(nazwa_funkcji_tb.Text));
                }
                catch
                {
                    MessageBox.Show("błędna nazwa serii! ");
                    nr_serii--;
                    return;
                }
                Form1.Series[nr_serii].ChartType = SeriesChartType.Line; // typ wykresu
                Form1.Series[nr_serii].BorderWidth = 2;   // szerokość lini wykresu

                for (double i = x_1; i <= x_2; i += 0.1)
                {
                    if (liniowa_radiob.Checked == true)
                    {
                        Form1.Series[nr_serii].Points.AddXY(i, liniowa(a, b, i));
                        do_zapisu += (i.ToString() + " " + Math.Round(liniowa(a, b, i), 3).ToString() + Environment.NewLine);

                    }
                    else if (kwadratowa_radiob.Checked == true)
                    {
                        Form1.Series[nr_serii].Points.AddXY(i, kwadratowa(a, b, c, i));
                        do_zapisu += (i.ToString() + " " + Math.Round(kwadratowa(a, b, c, i), 3).ToString() + Environment.NewLine);
                    }
                    else if (sinus.Checked == true)
                    {
                        Form1.Series[nr_serii].Points.AddXY(i, sinusf(a, b, c, i));
                        do_zapisu += (i.ToString() + " " + Math.Round(sinusf(a, b, c, i), 3).ToString() + Environment.NewLine);
                    }


                }

        }

        bool dane_wejsciowe()
        {
            bool poprawne = true;
            if (Double.TryParse(a_lin_tb.Text, out a) && Double.TryParse(b_lin_tb.Text, out b) &&
                Double.TryParse(x_min.Text, out x_1) && Double.TryParse(x_max.Text, out x_2) &&
                Double.TryParse(c_tb.Text, out c))
            {
                a = double.Parse(a_lin_tb.Text);
                b = double.Parse(b_lin_tb.Text);
                c = double.Parse(c_tb.Text);
                x_1 = double.Parse(x_min.Text);
                x_2 = double.Parse(x_max.Text);
                return poprawne;
            }
            else
            {
                poprawne = false;
                MessageBox.Show("Błędny format danej", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return poprawne;
            }

        }

        private void zapisz_butt_Click(object sender, EventArgs e)
        {
            SaveFileDialog okno_dial = new SaveFileDialog();
            if (okno_dial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(okno_dial.FileName, do_zapisu);
            }
            else
                return;
        }

        private void wczytaj_butt_Click(object sender, EventArgs e)
        {
            OpenFileDialog okno_dial = new OpenFileDialog();
            if (okno_dial.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Form1.Series.Add(new Series("z pliku " + nr_serii.ToString()));
                Form1.Series[nr_serii].ChartType = SeriesChartType.Line;
                foreach (string line in File.ReadLines(okno_dial.FileName))
                {
                    string[] danes = line.Split(' ');
                    Form1.Series[nr_serii].Points.AddXY(double.Parse(danes[0]), double.Parse(danes[1]));
                }
                nr_serii++; 
            }
            else
            {
                MessageBox.Show("Nie wczytano!");
                return;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

    }
}
