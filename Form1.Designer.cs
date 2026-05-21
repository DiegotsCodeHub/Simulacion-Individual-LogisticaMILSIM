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
            this.dgvNumeros = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPseudoaleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.lblA = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblM = new System.Windows.Forms.Label();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.lblXo = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.cmdGenerar = new System.Windows.Forms.Button();
            this.cmbIntensidadCombate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbConvoyRiesgo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMunicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoConvoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoFaltante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // numInventario
            // 
            this.numInventario.Location = new System.Drawing.Point(622, 66);
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
            this.numReorden.Location = new System.Drawing.Point(622, 93);
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
            this.numRestock.Location = new System.Drawing.Point(622, 120);
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
            this.btnSimular.Location = new System.Drawing.Point(87, 608);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(122, 55);
            this.btnSimular.TabIndex = 4;
            this.btnSimular.Text = "Ejecutar Simulacion";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // lstEventos
            // 
            this.lstEventos.FormattingEnabled = true;
            this.lstEventos.Location = new System.Drawing.Point(1075, 65);
            this.lstEventos.Name = "lstEventos";
            this.lstEventos.Size = new System.Drawing.Size(239, 290);
            this.lstEventos.TabIndex = 5;
            // 
            // chartMunicion
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMunicion.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMunicion.Legends.Add(legend1);
            this.chartMunicion.Location = new System.Drawing.Point(366, 283);
            this.chartMunicion.Name = "chartMunicion";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Municion";
            this.chartMunicion.Series.Add(series1);
            this.chartMunicion.Size = new System.Drawing.Size(693, 380);
            this.chartMunicion.TabIndex = 6;
            this.chartMunicion.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 10F);
            this.label1.Location = new System.Drawing.Point(363, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad de municiones Iniciales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 10F);
            this.label2.Location = new System.Drawing.Point(367, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad de municiones criticas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 10F);
            this.label3.Location = new System.Drawing.Point(430, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad a reabastecer";
            // 
            // lstFaltantes
            // 
            this.lstFaltantes.FormattingEnabled = true;
            this.lstFaltantes.Location = new System.Drawing.Point(1075, 360);
            this.lstFaltantes.Name = "lstFaltantes";
            this.lstFaltantes.Size = new System.Drawing.Size(239, 303);
            this.lstFaltantes.TabIndex = 10;
            // 
            // lstConvoy
            // 
            this.lstConvoy.FormattingEnabled = true;
            this.lstConvoy.Location = new System.Drawing.Point(1320, 66);
            this.lstConvoy.Name = "lstConvoy";
            this.lstConvoy.Size = new System.Drawing.Size(239, 290);
            this.lstConvoy.TabIndex = 12;
            // 
            // lstCostos
            // 
            this.lstCostos.FormattingEnabled = true;
            this.lstCostos.Location = new System.Drawing.Point(1320, 362);
            this.lstCostos.Name = "lstCostos";
            this.lstCostos.Size = new System.Drawing.Size(239, 303);
            this.lstCostos.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 10F);
            this.label8.Location = new System.Drawing.Point(753, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Costo de Convoy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 10F);
            this.label9.Location = new System.Drawing.Point(720, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Costo por faltantes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 10F);
            this.label10.Location = new System.Drawing.Point(723, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Costo de Inventario";
            // 
            // numCostoConvoy
            // 
            this.numCostoConvoy.Location = new System.Drawing.Point(885, 120);
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
            this.numCostoFaltante.Location = new System.Drawing.Point(885, 93);
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
            this.numCostoInventario.Location = new System.Drawing.Point(885, 66);
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
            this.label11.Location = new System.Drawing.Point(586, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Horas de combate\r\n";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(733, 152);
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
            this.lblConsumoTotal.Location = new System.Drawing.Point(390, 213);
            this.lblConsumoTotal.Name = "lblConsumoTotal";
            this.lblConsumoTotal.Size = new System.Drawing.Size(212, 16);
            this.lblConsumoTotal.TabIndex = 33;
            this.lblConsumoTotal.Text = "Consumo total de municiones:";
            // 
            // lblFaltantesTotales
            // 
            this.lblFaltantesTotales.AutoSize = true;
            this.lblFaltantesTotales.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltantesTotales.Location = new System.Drawing.Point(390, 233);
            this.lblFaltantesTotales.Name = "lblFaltantesTotales";
            this.lblFaltantesTotales.Size = new System.Drawing.Size(162, 16);
            this.lblFaltantesTotales.TabIndex = 34;
            this.lblFaltantesTotales.Text = "Municiones faltantes:";
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotal.Location = new System.Drawing.Point(390, 255);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(203, 16);
            this.lblCostoTotal.TabIndex = 36;
            this.lblCostoTotal.Text = "Costo total de la operacion:";
            // 
            // lblConvoyes
            // 
            this.lblConvoyes.AutoSize = true;
            this.lblConvoyes.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvoyes.Location = new System.Drawing.Point(683, 213);
            this.lblConvoyes.Name = "lblConvoyes";
            this.lblConvoyes.Size = new System.Drawing.Size(215, 16);
            this.lblConvoyes.TabIndex = 35;
            this.lblConvoyes.Text = "Cantidad de Convoys enviados:";
            // 
            // lblHorasSinMunicion
            // 
            this.lblHorasSinMunicion.AutoSize = true;
            this.lblHorasSinMunicion.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasSinMunicion.Location = new System.Drawing.Point(683, 233);
            this.lblHorasSinMunicion.Name = "lblHorasSinMunicion";
            this.lblHorasSinMunicion.Size = new System.Drawing.Size(224, 16);
            this.lblHorasSinMunicion.TabIndex = 38;
            this.lblHorasSinMunicion.Text = "Horas de combate sin municion:";
            // 
            // lblEficiencia
            // 
            this.lblEficiencia.AutoSize = true;
            this.lblEficiencia.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEficiencia.Location = new System.Drawing.Point(683, 255);
            this.lblEficiencia.Name = "lblEficiencia";
            this.lblEficiencia.Size = new System.Drawing.Size(246, 16);
            this.lblEficiencia.TabIndex = 37;
            this.lblEficiencia.Text = "Eficiencia general de la logistica:";
            // 
            // btnNumPseudo
            // 
            this.btnNumPseudo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnNumPseudo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNumPseudo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumPseudo.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumPseudo.Location = new System.Drawing.Point(215, 610);
            this.btnNumPseudo.Name = "btnNumPseudo";
            this.btnNumPseudo.Size = new System.Drawing.Size(122, 55);
            this.btnNumPseudo.TabIndex = 39;
            this.btnNumPseudo.Text = "Numeros PseudoAleatorios";
            this.btnNumPseudo.UseVisualStyleBackColor = false;
            this.btnNumPseudo.Click += new System.EventHandler(this.btnNumPseudo_Click);
            // 
            // dgvNumeros
            // 
            this.dgvNumeros.AllowUserToResizeColumns = false;
            this.dgvNumeros.AllowUserToResizeRows = false;
            this.dgvNumeros.ColumnHeadersHeight = 29;
            this.dgvNumeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNumeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colPseudoaleatorio});
            this.dgvNumeros.Location = new System.Drawing.Point(87, 283);
            this.dgvNumeros.Name = "dgvNumeros";
            this.dgvNumeros.ReadOnly = true;
            this.dgvNumeros.RowHeadersWidth = 51;
            this.dgvNumeros.RowTemplate.Height = 25;
            this.dgvNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNumeros.Size = new System.Drawing.Size(250, 319);
            this.dgvNumeros.TabIndex = 42;
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "N";
            this.colNumero.MinimumWidth = 6;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 50;
            // 
            // colPseudoaleatorio
            // 
            this.colPseudoaleatorio.HeaderText = "Numero PseudoAleatorio";
            this.colPseudoaleatorio.MinimumWidth = 6;
            this.colPseudoaleatorio.Name = "colPseudoaleatorio";
            this.colPseudoaleatorio.ReadOnly = true;
            this.colPseudoaleatorio.Width = 147;
            // 
            // gbxDatos
            // 
            this.gbxDatos.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.gbxDatos.Controls.Add(this.lblA);
            this.gbxDatos.Controls.Add(this.txtTotal);
            this.gbxDatos.Controls.Add(this.txtA);
            this.gbxDatos.Controls.Add(this.lblTotal);
            this.gbxDatos.Controls.Add(this.txtC);
            this.gbxDatos.Controls.Add(this.lblM);
            this.gbxDatos.Controls.Add(this.txtXo);
            this.gbxDatos.Controls.Add(this.lblXo);
            this.gbxDatos.Controls.Add(this.txtM);
            this.gbxDatos.Controls.Add(this.lblC);
            this.gbxDatos.Location = new System.Drawing.Point(102, 71);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(220, 158);
            this.gbxDatos.TabIndex = 41;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(15, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(92, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Multiplicador";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(113, 121);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(86, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.Text = "325";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(113, 20);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(86, 20);
            this.txtA.TabIndex = 1;
            this.txtA.Text = "101";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(15, 125);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(113, 46);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(86, 20);
            this.txtC.TabIndex = 3;
            this.txtC.Text = "221";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblM.Location = new System.Drawing.Point(15, 100);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(50, 13);
            this.lblM.TabIndex = 6;
            this.lblM.Text = "Modulo";
            // 
            // txtXo
            // 
            this.txtXo.Location = new System.Drawing.Point(113, 71);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(86, 20);
            this.txtXo.TabIndex = 5;
            this.txtXo.Text = "17";
            this.txtXo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblXo
            // 
            this.lblXo.AutoSize = true;
            this.lblXo.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXo.Location = new System.Drawing.Point(15, 75);
            this.lblXo.Name = "lblXo";
            this.lblXo.Size = new System.Drawing.Size(51, 13);
            this.lblXo.TabIndex = 4;
            this.lblXo.Text = "Semilla";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(113, 96);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(86, 20);
            this.txtM.TabIndex = 7;
            this.txtM.Text = "17001";
            this.txtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(15, 50);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(74, 13);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "Incremento";
            // 
            // cmdGenerar
            // 
            this.cmdGenerar.BackColor = System.Drawing.Color.OliveDrab;
            this.cmdGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGenerar.Location = new System.Drawing.Point(87, 237);
            this.cmdGenerar.Name = "cmdGenerar";
            this.cmdGenerar.Size = new System.Drawing.Size(250, 31);
            this.cmdGenerar.TabIndex = 40;
            this.cmdGenerar.Text = "Generar";
            this.cmdGenerar.UseVisualStyleBackColor = false;
            this.cmdGenerar.Click += new System.EventHandler(this.cmdGenerar_Click);
            // 
            // cmbIntensidadCombate
            // 
            this.cmbIntensidadCombate.FormattingEnabled = true;
            this.cmbIntensidadCombate.Items.AddRange(new object[] {
            "Patrulla",
            "Baja",
            "Media",
            "Alta"});
            this.cmbIntensidadCombate.Location = new System.Drawing.Point(578, 181);
            this.cmbIntensidadCombate.Name = "cmbIntensidadCombate";
            this.cmbIntensidadCombate.Size = new System.Drawing.Size(108, 21);
            this.cmbIntensidadCombate.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 10F);
            this.label4.Location = new System.Drawing.Point(397, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Intensidad de Combate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 10F);
            this.label5.Location = new System.Drawing.Point(726, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 46;
            this.label5.Text = "Riesgo para Convoy";
            // 
            // cmbConvoyRiesgo
            // 
            this.cmbConvoyRiesgo.FormattingEnabled = true;
            this.cmbConvoyRiesgo.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.cmbConvoyRiesgo.Location = new System.Drawing.Point(885, 181);
            this.cmbConvoyRiesgo.Name = "cmbConvoyRiesgo";
            this.cmbConvoyRiesgo.Size = new System.Drawing.Size(108, 21);
            this.cmbConvoyRiesgo.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(583, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(419, 32);
            this.label7.TabIndex = 48;
            this.label7.Text = "Cruz Patino Diego - 22210297";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(97, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(466, 29);
            this.label6.TabIndex = 47;
            this.label6.Text = "LOGISTICA DE MUNICIONES EN COMBATE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::SimulacionMILSIM.Properties.Resources.tabletUW2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1612, 813);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbConvoyRiesgo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbIntensidadCombate);
            this.Controls.Add(this.dgvNumeros);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.cmdGenerar);
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
            ((System.ComponentModel.ISupportInitialize)(this.numCostoConvoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoFaltante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCostoInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumeros)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPseudoaleatorio;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.Label lblXo;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button cmdGenerar;
        private System.Windows.Forms.ComboBox cmbIntensidadCombate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbConvoyRiesgo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

