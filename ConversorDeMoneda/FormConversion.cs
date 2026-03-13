using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeMoneda
{
    public partial class FormConversion : Form
    {
        CN_Auditoria auditoria = new CN_Auditoria();
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Sesion.UsuarioNombre + " " +"ID:"+ Sesion.UsuarioID + Sesion.Rol;

            CN_TasaCambio objeto = new CN_TasaCambio();
            cmbMoneda.DataSource = objeto.MostrarTasa();
            cmbMoneda.DisplayMember = "MonedaNombre";
            cmbMoneda.ValueMember = "TasaID";
            

        }

        private void cmbMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView fila = (DataRowView)cmbMoneda.SelectedItem;
            lblTasa.Text = $"{fila["ValorTasa"]}";

        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Conversion calculo = new CN_Conversion();
                string resultado = calculo.ObtenerConversion(txtMonto.Text, lblTasa.Text);
                lblResultado.Text = resultado;
                calculo.InsertarConversion(Sesion.UsuarioID.ToString(), cmbMoneda.SelectedValue.ToString(), txtMonto.Text, resultado, lblTasa.Text);
                auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Conversion - Ejecutada");

            }
            catch(Exception ex) 
            {
                auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Conversion - Fallo");
                MessageBox.Show("Conversion no realizada por : " + ex);
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
