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
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rysuj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // wykres
            // 
            lineAnnotation1.AxisXName = "ChartArea1\\rX";
            lineAnnotation1.Name = "LineAnnotation1";
            lineAnnotation1.YAxisName = "ChartArea1\\rY";
            this.wykres.Annotations.Add(lineAnnotation1);
            chartArea1.Name = "ChartArea1";
            this.wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.wykres.Legends.Add(legend1);
            this.wykres.Location = new System.Drawing.Point(12, 12);
            this.wykres.Name = "wykres";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.wykres.Series.Add(series1);
            this.wykres.Size = new System.Drawing.Size(558, 288);
            this.wykres.TabIndex = 0;
            this.wykres.Text = "chart1";
            title1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.Name = "Title1";
            title1.Text = "Tytuł";
            this.wykres.Titles.Add(title1);
            // 
            // rysuj
            // 
            this.rysuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rysuj.Location = new System.Drawing.Point(12, 405);
            this.rysuj.Name = "rysuj";
            this.rysuj.Size = new System.Drawing.Size(85, 37);
            this.rysuj.TabIndex = 1;
            this.rysuj.Text = "RYSUJ";
            this.rysuj.UseVisualStyleBackColor = true;
            this.rysuj.Click += new System.EventHandler(this.rysuj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "f(x)=ax+b";
            // 
            // a_lin_tb
            // 
            this.a_lin_tb.Location = new System.Drawing.Point(47, 349);
            this.a_lin_tb.Name = "a_lin_tb";
            this.a_lin_tb.Size = new System.Drawing.Size(28, 22);
            this.a_lin_tb.TabIndex = 3;
            this.a_lin_tb.Text = "1";
            this.a_lin_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_lin_tb
            // 
            this.b_lin_tb.Location = new System.Drawing.Point(47, 377);
            this.b_lin_tb.Name = "b_lin_tb";
            this.b_lin_tb.Size = new System.Drawing.Size(28, 22);
            this.b_lin_tb.TabIndex = 4;
            this.b_lin_tb.Text = "1";
            this.b_lin_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "a =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "b =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Oś X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "min.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "max.";
            // 
            // x_min
            // 
            this.x_min.Location = new System.Drawing.Point(422, 337);
            this.x_min.Name = "x_min";
            this.x_min.Size = new System.Drawing.Size(36, 22);
            this.x_min.TabIndex = 11;
            this.x_min.Text = "0";
            this.x_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // x_max
            // 
            this.x_max.Location = new System.Drawing.Point(422, 369);
            this.x_max.Name = "x_max";
            this.x_max.Size = new System.Drawing.Size(36, 22);
            this.x_max.TabIndex = 12;
            this.x_max.Text = "10";
            this.x_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // usun_but
            // 
            this.usun_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usun_but.Location = new System.Drawing.Point(485, 343);
            this.usun_but.Name = "usun_but";
            this.usun_but.Size = new System.Drawing.Size(85, 37);
            this.usun_but.TabIndex = 15;
            this.usun_but.Text = "USUŃ";
            this.usun_but.UseVisualStyleBackColor = true;
            this.usun_but.Click += new System.EventHandler(this.usun_but_Click);
            // 
            // usun_serie
            // 
            this.usun_serie.Location = new System.Drawing.Point(542, 315);
            this.usun_serie.Name = "usun_serie";
            this.usun_serie.Size = new System.Drawing.Size(28, 22);
            this.usun_serie.TabIndex = 16;
            this.usun_serie.Text = "0";
            this.usun_serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "nr. serii";
            // 
            // funkcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 464);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rysuj);
            this.Controls.Add(this.wykres);
            this.Name = "funkcje";
            this.Text = "FUNKCJE";
            this.Load += new System.EventHandler(this.funkcje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart wykres;
        private System.Windows.Forms.Button rysuj;
        private System.Windows.Forms.Label label1;
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
    }
}

