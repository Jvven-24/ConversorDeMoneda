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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblmoneda = new System.Windows.Forms.Label();
            this.lblTasa = new System.Windows.Forms.Label();
            this.txtTasaDeCambio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.btnREGISTRO = new System.Windows.Forms.Button();
            this.btnTASACAMBIO = new System.Windows.Forms.Button();
            this.btnUSUARIO = new System.Windows.Forms.Button();
            this.btnINICIO = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelinicio = new System.Windows.Forms.Panel();
            this.panelbotones = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblrol = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelbotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.dataGridView2.Location = new System.Drawing.Point(206, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(677, 516);
            this.dataGridView2.TabIndex = 0;
            // 
            // txtMoneda
            // 
            this.txtMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.txtMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.txtMoneda.Location = new System.Drawing.Point(54, 66);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(179, 20);
            this.txtMoneda.TabIndex = 1;
            // 
            // lblmoneda
            // 
            this.lblmoneda.AutoSize = true;
            this.lblmoneda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblmoneda.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.lblmoneda.Location = new System.Drawing.Point(111, 24);
            this.lblmoneda.Name = "lblmoneda";
            this.lblmoneda.Size = new System.Drawing.Size(55, 15);
            this.lblmoneda.TabIndex = 2;
            this.lblmoneda.Text = "Moneda:";
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTasa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.lblTasa.Location = new System.Drawing.Point(96, 112);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(91, 15);
            this.lblTasa.TabIndex = 4;
            this.lblTasa.Text = "Tasa de Cambio:";
            // 
            // txtTasaDeCambio
            // 
            this.txtTasaDeCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.txtTasaDeCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.txtTasaDeCambio.Location = new System.Drawing.Point(54, 139);
            this.txtTasaDeCambio.Name = "txtTasaDeCambio";
            this.txtTasaDeCambio.Size = new System.Drawing.Size(179, 20);
            this.txtTasaDeCambio.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.btnGuardar.Location = new System.Drawing.Point(16, 219);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(244, 41);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEditar.Location = new System.Drawing.Point(16, 296);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnEliminar.Location = new System.Drawing.Point(143, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnAuditoria);
            this.panel1.Controls.Add(this.btnREGISTRO);
            this.panel1.Controls.Add(this.btnTASACAMBIO);
            this.panel1.Controls.Add(this.btnUSUARIO);
            this.panel1.Controls.Add(this.btnINICIO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 531);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.btnAuditoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuditoria.FlatAppearance.BorderSize = 0;
            this.btnAuditoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuditoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuditoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnAuditoria.Location = new System.Drawing.Point(0, 410);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(200, 132);
            this.btnAuditoria.TabIndex = 12;
            this.btnAuditoria.Text = "AUDITORIA";
            this.btnAuditoria.UseVisualStyleBackColor = false;
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // btnREGISTRO
            // 
            this.btnREGISTRO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.btnREGISTRO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnREGISTRO.FlatAppearance.BorderSize = 0;
            this.btnREGISTRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREGISTRO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREGISTRO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnREGISTRO.Location = new System.Drawing.Point(0, 306);
            this.btnREGISTRO.Name = "btnREGISTRO";
            this.btnREGISTRO.Size = new System.Drawing.Size(200, 104);
            this.btnREGISTRO.TabIndex = 11;
            this.btnREGISTRO.Text = "REGISTRO";
            this.btnREGISTRO.UseVisualStyleBackColor = false;
            this.btnREGISTRO.Click += new System.EventHandler(this.btnREGISTRO_Click);
            this.btnREGISTRO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.btnREGISTRO.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // btnTASACAMBIO
            // 
            this.btnTASACAMBIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.btnTASACAMBIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTASACAMBIO.FlatAppearance.BorderSize = 0;
            this.btnTASACAMBIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTASACAMBIO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTASACAMBIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnTASACAMBIO.Location = new System.Drawing.Point(0, 207);
            this.btnTASACAMBIO.Name = "btnTASACAMBIO";
            this.btnTASACAMBIO.Size = new System.Drawing.Size(200, 99);
            this.btnTASACAMBIO.TabIndex = 10;
            this.btnTASACAMBIO.Text = "TASA DE CAMBIO";
            this.btnTASACAMBIO.UseVisualStyleBackColor = false;
            this.btnTASACAMBIO.Click += new System.EventHandler(this.btnTASACAMBIO_Click);
            this.btnTASACAMBIO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.btnTASACAMBIO.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // btnUSUARIO
            // 
            this.btnUSUARIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.btnUSUARIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUSUARIO.FlatAppearance.BorderSize = 0;
            this.btnUSUARIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSUARIO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSUARIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnUSUARIO.Location = new System.Drawing.Point(0, 99);
            this.btnUSUARIO.Name = "btnUSUARIO";
            this.btnUSUARIO.Size = new System.Drawing.Size(200, 108);
            this.btnUSUARIO.TabIndex = 9;
            this.btnUSUARIO.Text = "USUARIO";
            this.btnUSUARIO.UseVisualStyleBackColor = false;
            this.btnUSUARIO.Click += new System.EventHandler(this.btnUSUARIO_Click);
            this.btnUSUARIO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.btnUSUARIO.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // btnINICIO
            // 
            this.btnINICIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.btnINICIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnINICIO.FlatAppearance.BorderSize = 0;
            this.btnINICIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINICIO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINICIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.btnINICIO.Location = new System.Drawing.Point(0, 0);
            this.btnINICIO.Name = "btnINICIO";
            this.btnINICIO.Size = new System.Drawing.Size(200, 99);
            this.btnINICIO.TabIndex = 0;
            this.btnINICIO.Text = "INICIO";
            this.btnINICIO.UseVisualStyleBackColor = false;
            this.btnINICIO.Click += new System.EventHandler(this.btnINICIO_Click);
            this.btnINICIO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.btnINICIO.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
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
            // panelinicio
            // 
            this.panelinicio.Location = new System.Drawing.Point(206, 3);
            this.panelinicio.Name = "panelinicio";
            this.panelinicio.Size = new System.Drawing.Size(677, 528);
            this.panelinicio.TabIndex = 9;
            this.panelinicio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelinicio_Paint);
            // 
            // panelbotones
            // 
            this.panelbotones.Controls.Add(this.lblUsuario);
            this.panelbotones.Controls.Add(this.lblrol);
            this.panelbotones.Controls.Add(this.txtMoneda);
            this.panelbotones.Controls.Add(this.btnEditar);
            this.panelbotones.Controls.Add(this.btnEliminar);
            this.panelbotones.Controls.Add(this.lblmoneda);
            this.panelbotones.Controls.Add(this.txtTasaDeCambio);
            this.panelbotones.Controls.Add(this.btnGuardar);
            this.panelbotones.Controls.Add(this.lblTasa);
            this.panelbotones.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelbotones.Location = new System.Drawing.Point(889, 0);
            this.panelbotones.Name = "panelbotones";
            this.panelbotones.Size = new System.Drawing.Size(272, 531);
            this.panelbotones.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.lblUsuario.Location = new System.Drawing.Point(72, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(158, 15);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Escriba el nombre de usuario";
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblrol.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.lblrol.Location = new System.Drawing.Point(111, 112);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(74, 15);
            this.lblrol.TabIndex = 8;
            this.lblrol.Text = "Escriba el rol";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1161, 531);
            this.Controls.Add(this.panelbotones);
            this.Controls.Add(this.panelinicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelbotones.ResumeLayout(false);
            this.panelbotones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblmoneda;
        private System.Windows.Forms.Label lblTasa;
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
        private System.Windows.Forms.Panel panelinicio;
        private System.Windows.Forms.Button btnAuditoria;
        private Guna.UI2.WinForms.Guna2Panel panelbotones;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblrol;
    }
}

