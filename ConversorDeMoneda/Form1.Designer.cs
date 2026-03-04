namespace ConversorDeMoneda
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTasaDeCambio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnINICIO = new System.Windows.Forms.Button();
            this.btnUSUARIO = new System.Windows.Forms.Button();
            this.btnTASACAMBIO = new System.Windows.Forms.Button();
            this.btnREGISTRO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(221, 40);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(586, 269);
            this.dataGridView2.TabIndex = 0;
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(906, 74);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(179, 20);
            this.txtMoneda.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moneda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasa de Cambio:";
            // 
            // txtTasaDeCambio
            // 
            this.txtTasaDeCambio.Location = new System.Drawing.Point(906, 140);
            this.txtTasaDeCambio.Name = "txtTasaDeCambio";
            this.txtTasaDeCambio.Size = new System.Drawing.Size(179, 20);
            this.txtTasaDeCambio.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(841, 245);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(244, 41);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(237, 339);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(676, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnREGISTRO);
            this.panel1.Controls.Add(this.btnTASACAMBIO);
            this.panel1.Controls.Add(this.btnUSUARIO);
            this.panel1.Controls.Add(this.btnINICIO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 531);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnINICIO
            // 
            this.btnINICIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnINICIO.Location = new System.Drawing.Point(0, 0);
            this.btnINICIO.Name = "btnINICIO";
            this.btnINICIO.Size = new System.Drawing.Size(200, 65);
            this.btnINICIO.TabIndex = 0;
            this.btnINICIO.Text = "INICIO";
            this.btnINICIO.UseVisualStyleBackColor = true;
            this.btnINICIO.Click += new System.EventHandler(this.btnINICIO_Click);
            this.btnINICIO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.btnINICIO.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // btnUSUARIO
            // 
            this.btnUSUARIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUSUARIO.Location = new System.Drawing.Point(0, 65);
            this.btnUSUARIO.Name = "btnUSUARIO";
            this.btnUSUARIO.Size = new System.Drawing.Size(200, 64);
            this.btnUSUARIO.TabIndex = 9;
            this.btnUSUARIO.Text = "USUARIO";
            this.btnUSUARIO.UseVisualStyleBackColor = true;
            this.btnUSUARIO.Click += new System.EventHandler(this.btnUSUARIO_Click);
            this.btnUSUARIO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.btnUSUARIO.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // btnTASACAMBIO
            // 
            this.btnTASACAMBIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTASACAMBIO.Location = new System.Drawing.Point(0, 129);
            this.btnTASACAMBIO.Name = "btnTASACAMBIO";
            this.btnTASACAMBIO.Size = new System.Drawing.Size(200, 64);
            this.btnTASACAMBIO.TabIndex = 10;
            this.btnTASACAMBIO.Text = "TASA DE CAMBIO";
            this.btnTASACAMBIO.UseVisualStyleBackColor = true;
            this.btnTASACAMBIO.Click += new System.EventHandler(this.btnTASACAMBIO_Click);
            this.btnTASACAMBIO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.btnTASACAMBIO.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // btnREGISTRO
            // 
            this.btnREGISTRO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnREGISTRO.Location = new System.Drawing.Point(0, 193);
            this.btnREGISTRO.Name = "btnREGISTRO";
            this.btnREGISTRO.Size = new System.Drawing.Size(200, 64);
            this.btnREGISTRO.TabIndex = 11;
            this.btnREGISTRO.Text = "REGISTRO";
            this.btnREGISTRO.UseVisualStyleBackColor = true;
            this.btnREGISTRO.Click += new System.EventHandler(this.btnREGISTRO_Click);
            this.btnREGISTRO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.btnREGISTRO.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1161, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTasaDeCambio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTasaDeCambio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
       private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnREGISTRO;
        private System.Windows.Forms.Button btnTASACAMBIO;
        private System.Windows.Forms.Button btnUSUARIO;
        private System.Windows.Forms.Button btnINICIO;
    }
}

