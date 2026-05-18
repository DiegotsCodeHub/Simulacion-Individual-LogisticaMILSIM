namespace SimulacionMILSIM
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
            this.numInventario = new System.Windows.Forms.NumericUpDown();
            this.numReorden = new System.Windows.Forms.NumericUpDown();
            this.numRestock = new System.Windows.Forms.NumericUpDown();
            this.btnSimular = new System.Windows.Forms.Button();
            this.lstEventos = new System.Windows.Forms.ListBox();
            this.chartMunicion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstFaltantes = new System.Windows.Forms.ListBox();
            this.lstConvoy = new System.Windows.Forms.ListBox();
            this.lstCostos = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMunicion)).BeginInit();
            this.SuspendLayout();
            // 
            // numInventario
            // 
            this.numInventario.Location = new System.Drawing.Point(206, 20);
            this.numInventario.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numInventario.Name = "numInventario";
            this.numInventario.Size = new System.Drawing.Size(64, 20);
            this.numInventario.TabIndex = 1;
            // 
            // numReorden
            // 
            this.numReorden.Location = new System.Drawing.Point(206, 47);
            this.numReorden.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numReorden.Name = "numReorden";
            this.numReorden.Size = new System.Drawing.Size(64, 20);
            this.numReorden.TabIndex = 2;
            // 
            // numRestock
            // 
            this.numRestock.Location = new System.Drawing.Point(206, 74);
            this.numRestock.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numRestock.Name = "numRestock";
            this.numRestock.Size = new System.Drawing.Size(64, 20);
            this.numRestock.TabIndex = 3;
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(537, 28);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(108, 55);
            this.btnSimular.TabIndex = 4;
            this.btnSimular.Text = "Ejecutar Simulacion";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.Location = new System.Drawing.Point(771, 13);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(239, 316);
            this.lstEventos.TabIndex = 5;
            // 
            // chartMunicion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMunicion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMunicion.Legends.Add(legend1);
            this.chartMunicion.Location = new System.Drawing.Point(12, 187);
            this.chartMunicion.Name = "chartMunicion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartMunicion.Series.Add(series1);
            this.chartMunicion.Size = new System.Drawing.Size(741, 481);
            this.chartMunicion.TabIndex = 6;
            this.chartMunicion.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de Municiones Iniciales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de Municiones criticas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad a reabastecer";
            // 
            // lstFaltantes
            // 
            this.lstFaltantes.FormattingEnabled = true;
            this.lstFaltantes.Location = new System.Drawing.Point(771, 349);
            this.lstFaltantes.Name = "lstFaltantes";
            this.lstFaltantes.Size = new System.Drawing.Size(239, 316);
            this.lstFaltantes.TabIndex = 10;
            // 
            // lstConvoy
            // 
            this.lstConvoy.FormattingEnabled = true;
            this.lstConvoy.Location = new System.Drawing.Point(1016, 12);
            this.lstConvoy.Name = "lstConvoy";
            this.lstConvoy.Size = new System.Drawing.Size(239, 316);
            this.lstConvoy.TabIndex = 12;
            // 
            // lstCostos
            // 
            this.lstCostos.FormattingEnabled = true;
            this.lstCostos.Location = new System.Drawing.Point(1019, 349);
            this.lstCostos.Name = "lstCostos";
            this.lstCostos.Size = new System.Drawing.Size(239, 316);
            this.lstCostos.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 680);
            this.Controls.Add(this.lstConvoy);
            this.Controls.Add(this.lstCostos);
            this.Controls.Add(this.lstFaltantes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartMunicion);
            this.Controls.Add(this.lstEventos);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.numRestock);
            this.Controls.Add(this.numReorden);
            this.Controls.Add(this.numInventario);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMunicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numInventario;
        private System.Windows.Forms.NumericUpDown numReorden;
        private System.Windows.Forms.NumericUpDown numRestock;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.ListBox lstEventos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMunicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstFaltantes;
        private System.Windows.Forms.ListBox lstConvoy;
        private System.Windows.Forms.ListBox lstCostos;
    }
}

