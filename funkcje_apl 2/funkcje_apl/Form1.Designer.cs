namespace funkcje_apl
{
    partial class funkcje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rysuj = new System.Windows.Forms.Button();
            this.zapisz_butt = new System.Windows.Forms.Button();
            this.wczytaj_butt = new System.Windows.Forms.Button();
            this.usun_but = new System.Windows.Forms.Button();
            this.liniowa_radiob = new System.Windows.Forms.RadioButton();
            this.kwadratowa_radiob = new System.Windows.Forms.RadioButton();
            this.sinus = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.x_min = new System.Windows.Forms.TextBox();
            this.x_max = new System.Windows.Forms.TextBox();
            this.usun_serie = new System.Windows.Forms.TextBox();
            this.a_lin_tb = new System.Windows.Forms.TextBox();
            this.c_tb = new System.Windows.Forms.TextBox();
            this.b_lin_tb = new System.Windows.Forms.TextBox();
            this.Form1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nazwa_funkcji_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Form1)).BeginInit();
            this.SuspendLayout();
            // 
            // rysuj
            // 
            this.rysuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rysuj.Location = new System.Drawing.Point(47, 559);
            this.rysuj.Name = "rysuj";
            this.rysuj.Size = new System.Drawing.Size(100, 33);
            this.rysuj.TabIndex = 0;
            this.rysuj.Text = "Rysuj";
            this.rysuj.UseVisualStyleBackColor = true;
            this.rysuj.Click += new System.EventHandler(this.rysuj_Click);
            // 
            // zapisz_butt
            // 
            this.zapisz_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapisz_butt.Location = new System.Drawing.Point(324, 450);
            this.zapisz_butt.Name = "zapisz_butt";
            this.zapisz_butt.Size = new System.Drawing.Size(91, 33);
            this.zapisz_butt.TabIndex = 1;
            this.zapisz_butt.Text = "Zapisz";
            this.zapisz_butt.UseVisualStyleBackColor = true;
            this.zapisz_butt.Click += new System.EventHandler(this.zapisz_butt_Click);
            // 
            // wczytaj_butt
            // 
            this.wczytaj_butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wczytaj_butt.Location = new System.Drawing.Point(324, 489);
            this.wczytaj_butt.Name = "wczytaj_butt";
            this.wczytaj_butt.Size = new System.Drawing.Size(91, 30);
            this.wczytaj_butt.TabIndex = 2;
            this.wczytaj_butt.Text = "Wczytaj";
            this.wczytaj_butt.UseVisualStyleBackColor = true;
            this.wczytaj_butt.Click += new System.EventHandler(this.wczytaj_butt_Click);
            // 
            // usun_but
            // 
            this.usun_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usun_but.Location = new System.Drawing.Point(644, 516);
            this.usun_but.Name = "usun_but";
            this.usun_but.Size = new System.Drawing.Size(92, 34);
            this.usun_but.TabIndex = 3;
            this.usun_but.Text = "Usuń";
            this.usun_but.UseVisualStyleBackColor = true;
            this.usun_but.Click += new System.EventHandler(this.usun_but_Click);
            // 
            // liniowa_radiob
            // 
            this.liniowa_radiob.AutoSize = true;
            this.liniowa_radiob.Checked = true;
            this.liniowa_radiob.Location = new System.Drawing.Point(47, 446);
            this.liniowa_radiob.Name = "liniowa_radiob";
            this.liniowa_radiob.Size = new System.Drawing.Size(90, 21);
            this.liniowa_radiob.TabIndex = 4;
            this.liniowa_radiob.TabStop = true;
            this.liniowa_radiob.Text = "y = ax + b";
            this.liniowa_radiob.UseVisualStyleBackColor = true;
            // 
            // kwadratowa_radiob
            // 
            this.kwadratowa_radiob.AutoSize = true;
            this.kwadratowa_radiob.Location = new System.Drawing.Point(47, 474);
            this.kwadratowa_radiob.Name = "kwadratowa_radiob";
            this.kwadratowa_radiob.Size = new System.Drawing.Size(126, 21);
            this.kwadratowa_radiob.TabIndex = 5;
            this.kwadratowa_radiob.Text = "y = ax^2 +bx +c";
            this.kwadratowa_radiob.UseVisualStyleBackColor = true;
            // 
            // sinus
            // 
            this.sinus.AutoSize = true;
            this.sinus.Location = new System.Drawing.Point(47, 502);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(125, 21);
            this.sinus.TabIndex = 6;
            this.sinus.Text = "y = asin(bx) + c";
            this.sinus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "c = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "min.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "max. ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(569, 464);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Oś X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(641, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nazwa serii";
            // 
            // x_min
            // 
            this.x_min.BackColor = System.Drawing.SystemColors.Info;
            this.x_min.Location = new System.Drawing.Point(572, 484);
            this.x_min.Name = "x_min";
            this.x_min.Size = new System.Drawing.Size(36, 22);
            this.x_min.TabIndex = 14;
            this.x_min.Text = "-10";
            this.x_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // x_max
            // 
            this.x_max.BackColor = System.Drawing.SystemColors.Info;
            this.x_max.Location = new System.Drawing.Point(572, 528);
            this.x_max.Name = "x_max";
            this.x_max.Size = new System.Drawing.Size(36, 22);
            this.x_max.TabIndex = 15;
            this.x_max.Text = "10";
            this.x_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // usun_serie
            // 
            this.usun_serie.BackColor = System.Drawing.SystemColors.Info;
            this.usun_serie.Location = new System.Drawing.Point(644, 484);
            this.usun_serie.Name = "usun_serie";
            this.usun_serie.Size = new System.Drawing.Size(62, 22);
            this.usun_serie.TabIndex = 16;
            this.usun_serie.Tag = "";
            this.usun_serie.Text = "funkcja";
            // 
            // a_lin_tb
            // 
            this.a_lin_tb.BackColor = System.Drawing.SystemColors.Info;
            this.a_lin_tb.Location = new System.Drawing.Point(227, 450);
            this.a_lin_tb.Name = "a_lin_tb";
            this.a_lin_tb.Size = new System.Drawing.Size(39, 22);
            this.a_lin_tb.TabIndex = 17;
            this.a_lin_tb.Text = "1";
            this.a_lin_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // c_tb
            // 
            this.c_tb.BackColor = System.Drawing.SystemColors.Info;
            this.c_tb.Location = new System.Drawing.Point(227, 506);
            this.c_tb.Name = "c_tb";
            this.c_tb.Size = new System.Drawing.Size(39, 22);
            this.c_tb.TabIndex = 18;
            this.c_tb.Text = "1";
            this.c_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_lin_tb
            // 
            this.b_lin_tb.BackColor = System.Drawing.SystemColors.Info;
            this.b_lin_tb.Location = new System.Drawing.Point(227, 478);
            this.b_lin_tb.Name = "b_lin_tb";
            this.b_lin_tb.Size = new System.Drawing.Size(39, 22);
            this.b_lin_tb.TabIndex = 19;
            this.b_lin_tb.Text = "1";
            this.b_lin_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            chartArea5.Name = "ChartArea1";
            this.Form1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.Form1.Legends.Add(legend5);
            this.Form1.Location = new System.Drawing.Point(12, 12);
            this.Form1.Name = "Form1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.Form1.Series.Add(series5);
            this.Form1.Size = new System.Drawing.Size(743, 406);
            this.Form1.TabIndex = 20;
            this.Form1.Text = "chart1";
            // 
            // nazwa_funkcji_tb
            // 
            this.nazwa_funkcji_tb.BackColor = System.Drawing.SystemColors.Info;
            this.nazwa_funkcji_tb.Location = new System.Drawing.Point(166, 570);
            this.nazwa_funkcji_tb.Name = "nazwa_funkcji_tb";
            this.nazwa_funkcji_tb.Size = new System.Drawing.Size(100, 22);
            this.nazwa_funkcji_tb.TabIndex = 21;
            this.nazwa_funkcji_tb.Text = "funkcja";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Nazwa funkcji";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // funkcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 603);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nazwa_funkcji_tb);
            this.Controls.Add(this.Form1);
            this.Controls.Add(this.b_lin_tb);
            this.Controls.Add(this.c_tb);
            this.Controls.Add(this.a_lin_tb);
            this.Controls.Add(this.usun_serie);
            this.Controls.Add(this.x_max);
            this.Controls.Add(this.x_min);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sinus);
            this.Controls.Add(this.kwadratowa_radiob);
            this.Controls.Add(this.liniowa_radiob);
            this.Controls.Add(this.usun_but);
            this.Controls.Add(this.wczytaj_butt);
            this.Controls.Add(this.zapisz_butt);
            this.Controls.Add(this.rysuj);
            this.Name = "funkcje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "funkcje";
            this.Load += new System.EventHandler(this.funkcje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Form1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rysuj;
        private System.Windows.Forms.Button zapisz_butt;
        private System.Windows.Forms.Button wczytaj_butt;
        private System.Windows.Forms.Button usun_but;
        private System.Windows.Forms.RadioButton liniowa_radiob;
        private System.Windows.Forms.RadioButton kwadratowa_radiob;
        private System.Windows.Forms.RadioButton sinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox x_min;
        private System.Windows.Forms.TextBox x_max;
        private System.Windows.Forms.TextBox usun_serie;
        private System.Windows.Forms.TextBox a_lin_tb;
        private System.Windows.Forms.TextBox c_tb;
        private System.Windows.Forms.TextBox b_lin_tb;
        private System.Windows.Forms.DataVisualization.Charting.Chart Form1;
        private System.Windows.Forms.TextBox nazwa_funkcji_tb;
        private System.Windows.Forms.Label label8;
    }
}

