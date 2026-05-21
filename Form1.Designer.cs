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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numTiempoMinConvoy = new System.Windows.Forms.NumericUpDown();
            this.numConsumoMin = new System.Windows.Forms.NumericUpDown();
            this.numConsumoMax = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numTiempoMaxConvoy = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numCostoConvoy = new System.Windows.Forms.NumericUpDown();
            this.numCostoFaltante = new System.Windows.Forms.NumericUpDown();
            this.numCostoInventario = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.lblConsumoTotal = new System.Windows.Forms.Label();
            this.lblFaltantesTotales = new System.Windows.Forms.Label();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblConvoyes = new System.Windows.Forms.Label();
            this.lblHorasSinMunicion = new System.Windows.Forms.Label();
            this.lblEficiencia = new System.Windows.Forms.Label();
            this.btnNumPseudo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPruebaFrec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMunicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoMinConvoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConsumoMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConsumoMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoMaxConvoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoConvoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoFaltante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numInventario
            // 
            this.numInventario.Location = new System.Drawing.Point(322, 68);
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
            this.numReorden.Location = new System.Drawing.Point(322, 95);
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
            this.numRestock.Location = new System.Drawing.Point(322, 122);
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
            this.btnSimular.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSimular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimular.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(280, 744);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(107, 55);
            this.btnSimular.TabIndex = 4;
            this.btnSimular.Text = "Ejecutar Simulacion";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.Location = new System.Drawing.Point(774, 67);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(239, 290);
            this.lstEventos.TabIndex = 5;
            // 
            // chartMunicion
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMunicion.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMunicion.Legends.Add(legend2);
            this.chartMunicion.Location = new System.Drawing.Point(62, 319);
            this.chartMunicion.Name = "chartMunicion";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Municion";
            this.chartMunicion.Series.Add(series2);
            this.chartMunicion.Size = new System.Drawing.Size(436, 346);
            this.chartMunicion.TabIndex = 6;
            this.chartMunicion.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10F);
            this.label1.Location = new System.Drawing.Point(63, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de municiones Iniciales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10F);
            this.label2.Location = new System.Drawing.Point(63, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de municiones criticas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 10F);
            this.label3.Location = new System.Drawing.Point(63, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad a reabastecer";
            // 
            // lstFaltantes
            // 
            this.lstFaltantes.FormattingEnabled = true;
            this.lstFaltantes.Location = new System.Drawing.Point(774, 362);
            this.lstFaltantes.Name = "lstFaltantes";
            this.lstFaltantes.Size = new System.Drawing.Size(239, 303);
            this.lstFaltantes.TabIndex = 10;
            // 
            // lstConvoy
            // 
            this.lstConvoy.FormattingEnabled = true;
            this.lstConvoy.Location = new System.Drawing.Point(1019, 68);
            this.lstConvoy.Name = "lstConvoy";
            this.lstConvoy.Size = new System.Drawing.Size(239, 290);
            this.lstConvoy.TabIndex = 12;
            // 
            // lstCostos
            // 
            this.lstCostos.FormattingEnabled = true;
            this.lstCostos.Location = new System.Drawing.Point(1019, 362);
            this.lstCostos.Name = "lstCostos";
            this.lstCostos.Size = new System.Drawing.Size(239, 303);
            this.lstCostos.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10F);
            this.label4.Location = new System.Drawing.Point(410, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tiempo minimo de entrega de Convoy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 10F);
            this.label5.Location = new System.Drawing.Point(63, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Minimo de municiones consumidas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 10F);
            this.label6.Location = new System.Drawing.Point(63, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Maximo de municiones consumidas";
            // 
            // numTiempoMinConvoy
            // 
            this.numTiempoMinConvoy.Location = new System.Drawing.Point(693, 164);
            this.numTiempoMinConvoy.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numTiempoMinConvoy.Name = "numTiempoMinConvoy";
            this.numTiempoMinConvoy.Size = new System.Drawing.Size(64, 20);
            this.numTiempoMinConvoy.TabIndex = 15;
            // 
            // numConsumoMin
            // 
            this.numConsumoMin.Location = new System.Drawing.Point(330, 193);
            this.numConsumoMin.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numConsumoMin.Name = "numConsumoMin";
            this.numConsumoMin.Size = new System.Drawing.Size(64, 20);
            this.numConsumoMin.TabIndex = 14;
            // 
            // numConsumoMax
            // 
            this.numConsumoMax.Location = new System.Drawing.Point(330, 166);
            this.numConsumoMax.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numConsumoMax.Name = "numConsumoMax";
            this.numConsumoMax.Size = new System.Drawing.Size(64, 20);
            this.numConsumoMax.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 10F);
            this.label7.Location = new System.Drawing.Point(410, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tiempo maximo de entrega de Convoy";
            // 
            // numTiempoMaxConvoy
            // 
            this.numTiempoMaxConvoy.Location = new System.Drawing.Point(693, 190);
            this.numTiempoMaxConvoy.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numTiempoMaxConvoy.Name = "numTiempoMaxConvoy";
            this.numTiempoMaxConvoy.Size = new System.Drawing.Size(64, 20);
            this.numTiempoMaxConvoy.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 10F);
            this.label8.Location = new System.Drawing.Point(420, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Costo de Convoy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 10F);
            this.label9.Location = new System.Drawing.Point(420, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Costo por faltantes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 10F);
            this.label10.Location = new System.Drawing.Point(420, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Costo de Inventario";
            // 
            // numCostoConvoy
            // 
            this.numCostoConvoy.Location = new System.Drawing.Point(585, 122);
            this.numCostoConvoy.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numCostoConvoy.Name = "numCostoConvoy";
            this.numCostoConvoy.Size = new System.Drawing.Size(64, 20);
            this.numCostoConvoy.TabIndex = 23;
            // 
            // numCostoFaltante
            // 
            this.numCostoFaltante.Location = new System.Drawing.Point(585, 95);
            this.numCostoFaltante.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numCostoFaltante.Name = "numCostoFaltante";
            this.numCostoFaltante.Size = new System.Drawing.Size(64, 20);
            this.numCostoFaltante.TabIndex = 22;
            // 
            // numCostoInventario
            // 
            this.numCostoInventario.Location = new System.Drawing.Point(585, 68);
            this.numCostoInventario.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numCostoInventario.Name = "numCostoInventario";
            this.numCostoInventario.Size = new System.Drawing.Size(64, 20);
            this.numCostoInventario.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 10F);
            this.label11.Location = new System.Drawing.Point(664, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 34);
            this.label11.TabIndex = 28;
            this.label11.Text = "Horas\r\nde combate\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(678, 109);
            this.numHoras.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(64, 20);
            this.numHoras.TabIndex = 27;
            // 
            // lblConsumoTotal
            // 
            this.lblConsumoTotal.AutoSize = true;
            this.lblConsumoTotal.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumoTotal.Location = new System.Drawing.Point(61, 236);
            this.lblConsumoTotal.Name = "lblConsumoTotal";
            this.lblConsumoTotal.Size = new System.Drawing.Size(212, 16);
            this.lblConsumoTotal.TabIndex = 33;
            this.lblConsumoTotal.Text = "Consumo total de municiones:";
            // 
            // lblFaltantesTotales
            // 
            this.lblFaltantesTotales.AutoSize = true;
            this.lblFaltantesTotales.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltantesTotales.Location = new System.Drawing.Point(61, 256);
            this.lblFaltantesTotales.Name = "lblFaltantesTotales";
            this.lblFaltantesTotales.Size = new System.Drawing.Size(162, 16);
            this.lblFaltantesTotales.TabIndex = 34;
            this.lblFaltantesTotales.Text = "Municiones faltantes:";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(61, 278);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(203, 16);
            this.lblCostoTotal.TabIndex = 36;
            this.lblCostoTotal.Text = "Costo total de la operacion:";
            // 
            // lblConvoyes
            // 
            this.lblConvoyes.AutoSize = true;
            this.lblConvoyes.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvoyes.Location = new System.Drawing.Point(354, 236);
            this.lblConvoyes.Name = "lblConvoyes";
            this.lblConvoyes.Size = new System.Drawing.Size(215, 16);
            this.lblConvoyes.TabIndex = 35;
            this.lblConvoyes.Text = "Cantidad de Convoys enviados:";
            // 
            // lblHorasSinMunicion
            // 
            this.lblHorasSinMunicion.AutoSize = true;
            this.lblHorasSinMunicion.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasSinMunicion.Location = new System.Drawing.Point(354, 256);
            this.lblHorasSinMunicion.Name = "lblHorasSinMunicion";
            this.lblHorasSinMunicion.Size = new System.Drawing.Size(224, 16);
            this.lblHorasSinMunicion.TabIndex = 38;
            this.lblHorasSinMunicion.Text = "Horas de combate sin municion:";
            // 
            // lblEficiencia
            // 
            this.lblEficiencia.AutoSize = true;
            this.lblEficiencia.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEficiencia.Location = new System.Drawing.Point(354, 278);
            this.lblEficiencia.Name = "lblEficiencia";
            this.lblEficiencia.Size = new System.Drawing.Size(246, 16);
            this.lblEficiencia.TabIndex = 37;
            this.lblEficiencia.Text = "Eficiencia general de la logistica:";
            // 
            // btnNumPseudo
            // 
            this.btnNumPseudo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnNumPseudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumPseudo.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPseudo.Location = new System.Drawing.Point(397, 743);
            this.btnNumPseudo.Name = "btnNumPseudo";
            this.btnNumPseudo.Size = new System.Drawing.Size(172, 55);
            this.btnNumPseudo.TabIndex = 39;
            this.btnNumPseudo.Text = "Numeros PseudoAleatorios";
            this.btnNumPseudo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(821, 742);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 55);
            this.button1.TabIndex = 40;
            this.button1.Text = "Prueba de Prueba K-S";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnPruebaFrec
            // 
            this.btnPruebaFrec.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPruebaFrec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPruebaFrec.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebaFrec.Location = new System.Drawing.Point(703, 741);
            this.btnPruebaFrec.Name = "btnPruebaFrec";
            this.btnPruebaFrec.Size = new System.Drawing.Size(107, 55);
            this.btnPruebaFrec.TabIndex = 41;
            this.btnPruebaFrec.Text = "Prueba de Frecuencia";
            this.btnPruebaFrec.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(510, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(253, 223);
            this.dataGridView1.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(510, 548);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 117);
            this.textBox1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::SimulacionMILSIM.Properties.Resources.tabletUW2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1304, 813);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPruebaFrec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNumPseudo);
            this.Controls.Add(this.lblHorasSinMunicion);
            this.Controls.Add(this.lblEficiencia);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.lblConvoyes);
            this.Controls.Add(this.lblFaltantesTotales);
            this.Controls.Add(this.lblConsumoTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numHoras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numCostoConvoy);
            this.Controls.Add(this.numCostoFaltante);
            this.Controls.Add(this.numCostoInventario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numTiempoMaxConvoy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numTiempoMinConvoy);
            this.Controls.Add(this.numConsumoMin);
            this.Controls.Add(this.numConsumoMax);
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
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "LOGISTICA DE MUNICIONES EN COMBATE";
            ((System.ComponentModel.ISupportInitialize)(this.numInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMunicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoMinConvoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConsumoMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConsumoMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTiempoMaxConvoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoConvoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoFaltante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numTiempoMinConvoy;
        private System.Windows.Forms.NumericUpDown numConsumoMin;
        private System.Windows.Forms.NumericUpDown numConsumoMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numTiempoMaxConvoy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numCostoConvoy;
        private System.Windows.Forms.NumericUpDown numCostoFaltante;
        private System.Windows.Forms.NumericUpDown numCostoInventario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.Label lblConsumoTotal;
        private System.Windows.Forms.Label lblFaltantesTotales;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblConvoyes;
        private System.Windows.Forms.Label lblHorasSinMunicion;
        private System.Windows.Forms.Label lblEficiencia;
        private System.Windows.Forms.Button btnNumPseudo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPruebaFrec;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

