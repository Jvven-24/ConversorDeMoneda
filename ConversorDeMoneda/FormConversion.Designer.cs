namespace ConversorDeMoneda
{
    partial class FormConversion
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
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.cmbMoneda = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlResultado = new Guna.UI2.WinForms.Guna2Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTasa = new System.Windows.Forms.Label();
            this.btnConversion = new System.Windows.Forms.Button();
            this.pnlCard.SuspendLayout();
            this.pnlResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlCard.BorderRadius = 12;
            this.pnlCard.Controls.Add(this.btnConversion);
            this.pnlCard.Controls.Add(this.pnlResultado);
            this.pnlCard.Controls.Add(this.txtMonto);
            this.pnlCard.Controls.Add(this.lblMonto);
            this.pnlCard.Controls.Add(this.cmbMoneda);
            this.pnlCard.Controls.Add(this.lblMoneda);
            this.pnlCard.Controls.Add(this.lblUsuario);
            this.pnlCard.Controls.Add(this.lblTitulo);
            this.pnlCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlCard.Location = new System.Drawing.Point(126, 106);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(449, 347);
            this.pnlCard.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.lblTitulo.Location = new System.Drawing.Point(25, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Hacer Conversión";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(269, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(104, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Juan García · Admin";
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.lblMoneda.Location = new System.Drawing.Point(25, 103);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(120, 13);
            this.lblMoneda.TabIndex = 2;
            this.lblMoneda.Text = "seleccione la  moneda";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.BackColor = System.Drawing.Color.Transparent;
            this.cmbMoneda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(85)))));
            this.cmbMoneda.BorderRadius = 8;
            this.cmbMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.cmbMoneda.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMoneda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMoneda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.cmbMoneda.ItemHeight = 30;
            this.cmbMoneda.Location = new System.Drawing.Point(36, 129);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(180, 36);
            this.cmbMoneda.TabIndex = 3;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(38)))), ((int)(((byte)(114)))));
            this.lblMonto.Location = new System.Drawing.Point(214, 100);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(78, 13);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "MontoOrigen";
            // 
            // txtMonto
            // 
            this.txtMonto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(85)))));
            this.txtMonto.BorderRadius = 8;
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.DefaultText = "";
            this.txtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMonto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(56)))));
            this.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMonto.Location = new System.Drawing.Point(229, 125);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PlaceholderText = "";
            this.txtMonto.SelectedText = "";
            this.txtMonto.Size = new System.Drawing.Size(200, 40);
            this.txtMonto.TabIndex = 5;
            // 
            // pnlResultado
            // 
            this.pnlResultado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.pnlResultado.BorderRadius = 10;
            this.pnlResultado.Controls.Add(this.lblTasa);
            this.pnlResultado.Controls.Add(this.lblResultado);
            this.pnlResultado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.pnlResultado.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlResultado.Location = new System.Drawing.Point(36, 187);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(380, 80);
            this.pnlResultado.TabIndex = 6;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(255)))), ((int)(((byte)(176)))));
            this.lblResultado.Location = new System.Drawing.Point(35, 21);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(145, 37);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(192)))), ((int)(((byte)(123)))));
            this.lblTasa.Location = new System.Drawing.Point(297, 31);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(41, 15);
            this.lblTasa.TabIndex = 1;
            this.lblTasa.Text = "Tasa: -";
            // 
            // btnConversion
            // 
            this.btnConversion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(31)))));
            this.btnConversion.Location = new System.Drawing.Point(147, 290);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(160, 40);
            this.btnConversion.TabIndex = 7;
            this.btnConversion.Text = "                                                                                 " +
    "         ";
            this.btnConversion.UseVisualStyleBackColor = true;
            // 
            // FormConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConversion";
            this.Load += new System.EventHandler(this.FormConversion_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2Panel pnlResultado;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnConversion;
    }
}