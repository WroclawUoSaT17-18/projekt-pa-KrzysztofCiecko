namespace funkcje
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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rysuj = new System.Windows.Forms.Button();
            this.a_lin_tb = new System.Windows.Forms.TextBox();
            this.b_lin_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.x_min = new System.Windows.Forms.TextBox();
            this.x_max = new System.Windows.Forms.TextBox();
            this.usun_but = new System.Windows.Forms.Button();
            this.usun_serie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.liniowa_radiob = new System.Windows.Forms.RadioButton();
            this.kwadratowa_radiob = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.c_tb = new System.Windows.Forms.TextBox();
            this.sinus = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Ampl_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // wykres
            // 
            lineAnnotation3.AxisXName = "ChartArea1\\rX";
            lineAnnotation3.Name = "LineAnnotation1";
            lineAnnotation3.YAxisName = "ChartArea1\\rY";
            this.wykres.Annotations.Add(lineAnnotation3);
            chartArea3.Name = "ChartArea1";
            this.wykres.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.wykres.Legends.Add(legend3);
            this.wykres.Location = new System.Drawing.Point(12, 12);
            this.wykres.Name = "wykres";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.wykres.Series.Add(series3);
            this.wykres.Size = new System.Drawing.Size(727, 341);
            this.wykres.TabIndex = 0;
            this.wykres.Text = "chart1";
            title3.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title3.Name = "Title1";
            title3.Text = "Tytuł";
            this.wykres.Titles.Add(title3);
            // 
            // rysuj
            // 
            this.rysuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rysuj.Location = new System.Drawing.Point(118, 477);
            this.rysuj.Name = "rysuj";
            this.rysuj.Size = new System.Drawing.Size(85, 37);
            this.rysuj.TabIndex = 1;
            this.rysuj.Text = "RYSUJ";
            this.rysuj.UseVisualStyleBackColor = true;
            this.rysuj.Click += new System.EventHandler(this.rysuj_Click);
            // 
            // a_lin_tb
            // 
            this.a_lin_tb.Location = new System.Drawing.Point(48, 406);
            this.a_lin_tb.Name = "a_lin_tb";
            this.a_lin_tb.Size = new System.Drawing.Size(28, 22);
            this.a_lin_tb.TabIndex = 3;
            this.a_lin_tb.Text = "1";
            this.a_lin_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_lin_tb
            // 
            this.b_lin_tb.Location = new System.Drawing.Point(48, 434);
            this.b_lin_tb.Name = "b_lin_tb";
            this.b_lin_tb.Size = new System.Drawing.Size(28, 22);
            this.b_lin_tb.TabIndex = 4;
            this.b_lin_tb.Text = "1";
            this.b_lin_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "b =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oś X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "min.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(462, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "max.";
            // 
            // x_min
            // 
            this.x_min.Location = new System.Drawing.Point(502, 398);
            this.x_min.Name = "x_min";
            this.x_min.Size = new System.Drawing.Size(36, 22);
            this.x_min.TabIndex = 11;
            this.x_min.Text = "0";
            this.x_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // x_max
            // 
            this.x_max.Location = new System.Drawing.Point(502, 430);
            this.x_max.Name = "x_max";
            this.x_max.Size = new System.Drawing.Size(36, 22);
            this.x_max.TabIndex = 12;
            this.x_max.Text = "10";
            this.x_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // usun_but
            // 
            this.usun_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usun_but.Location = new System.Drawing.Point(565, 404);
            this.usun_but.Name = "usun_but";
            this.usun_but.Size = new System.Drawing.Size(85, 37);
            this.usun_but.TabIndex = 15;
            this.usun_but.Text = "USUŃ";
            this.usun_but.UseVisualStyleBackColor = true;
            this.usun_but.Click += new System.EventHandler(this.usun_but_Click);
            // 
            // usun_serie
            // 
            this.usun_serie.Location = new System.Drawing.Point(622, 376);
            this.usun_serie.Name = "usun_serie";
            this.usun_serie.Size = new System.Drawing.Size(28, 22);
            this.usun_serie.TabIndex = 16;
            this.usun_serie.Text = "0";
            this.usun_serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "nr. serii";
            // 
            // liniowa_radiob
            // 
            this.liniowa_radiob.AutoSize = true;
            this.liniowa_radiob.Checked = true;
            this.liniowa_radiob.Location = new System.Drawing.Point(24, 377);
            this.liniowa_radiob.Name = "liniowa_radiob";
            this.liniowa_radiob.Size = new System.Drawing.Size(74, 21);
            this.liniowa_radiob.TabIndex = 18;
            this.liniowa_radiob.TabStop = true;
            this.liniowa_radiob.Text = "y=ax+b";
            this.liniowa_radiob.UseVisualStyleBackColor = true;
            // 
            // kwadratowa_radiob
            // 
            this.kwadratowa_radiob.AutoSize = true;
            this.kwadratowa_radiob.Location = new System.Drawing.Point(118, 376);
            this.kwadratowa_radiob.Name = "kwadratowa_radiob";
            this.kwadratowa_radiob.Size = new System.Drawing.Size(110, 21);
            this.kwadratowa_radiob.TabIndex = 19;
            this.kwadratowa_radiob.Text = "y=ax^2+bx+c";
            this.kwadratowa_radiob.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "c =";
            // 
            // c_tb
            // 
            this.c_tb.Location = new System.Drawing.Point(142, 406);
            this.c_tb.Name = "c_tb";
            this.c_tb.Size = new System.Drawing.Size(28, 22);
            this.c_tb.TabIndex = 20;
            this.c_tb.Text = "1";
            this.c_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sinus
            // 
            this.sinus.AutoSize = true;
            this.sinus.Location = new System.Drawing.Point(246, 376);
            this.sinus.Name = "sinus";
            this.sinus.Size = new System.Drawing.Size(110, 21);
            this.sinus.TabIndex = 22;
            this.sinus.Text = "y=Asin(bx)+c";
            this.sinus.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "A =";
            // 
            // Ampl_tb
            // 
            this.Ampl_tb.Location = new System.Drawing.Point(270, 406);
            this.Ampl_tb.Name = "Ampl_tb";
            this.Ampl_tb.Size = new System.Drawing.Size(28, 22);
            this.Ampl_tb.TabIndex = 23;
            this.Ampl_tb.Text = "1";
            this.Ampl_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // funkcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(751, 526);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Ampl_tb);
            this.Controls.Add(this.sinus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_tb);
            this.Controls.Add(this.kwadratowa_radiob);
            this.Controls.Add(this.liniowa_radiob);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.usun_serie);
            this.Controls.Add(this.usun_but);
            this.Controls.Add(this.x_max);
            this.Controls.Add(this.x_min);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_lin_tb);
            this.Controls.Add(this.a_lin_tb);
            this.Controls.Add(this.rysuj);
            this.Controls.Add(this.wykres);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "funkcje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUNKCJE";
            this.Load += new System.EventHandler(this.funkcje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart wykres;
        private System.Windows.Forms.Button rysuj;
        private System.Windows.Forms.TextBox a_lin_tb;
        private System.Windows.Forms.TextBox b_lin_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox x_min;
        private System.Windows.Forms.TextBox x_max;
        private System.Windows.Forms.Button usun_but;
        private System.Windows.Forms.TextBox usun_serie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton liniowa_radiob;
        private System.Windows.Forms.RadioButton kwadratowa_radiob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_tb;
        private System.Windows.Forms.RadioButton sinus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Ampl_tb;
    }
}

