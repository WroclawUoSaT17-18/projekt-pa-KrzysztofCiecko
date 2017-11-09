namespace funkcje
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.wzor = new System.Windows.Forms.TextBox();
            this.generuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).BeginInit();
            this.SuspendLayout();
            // 
            // Wykres
            // 
            chartArea1.Name = "ChartArea1";
            this.Wykres.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 20;
            legend1.Name = "Legend1";
            this.Wykres.Legends.Add(legend1);
            this.Wykres.Location = new System.Drawing.Point(12, 12);
            this.Wykres.Name = "Wykres";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Wykres.Series.Add(series1);
            this.Wykres.Size = new System.Drawing.Size(528, 341);
            this.Wykres.TabIndex = 0;
            this.Wykres.Text = "chart1";
            // 
            // wzor
            // 
            this.wzor.Location = new System.Drawing.Point(398, 380);
            this.wzor.Name = "wzor";
            this.wzor.Size = new System.Drawing.Size(100, 22);
            this.wzor.TabIndex = 1;
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(55, 380);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(103, 43);
            this.generuj.TabIndex = 2;
            this.generuj.Text = "generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 435);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.wzor);
            this.Controls.Add(this.Wykres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wykres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Wykres;
        private System.Windows.Forms.TextBox wzor;
        private System.Windows.Forms.Button generuj;
    }
}

