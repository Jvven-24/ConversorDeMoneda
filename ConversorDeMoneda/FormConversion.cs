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
           ;

            CN_TasaCambio objeto = new CN_TasaCambio();
            DataTable tasas = objeto.MostrarTasa();

            cmbMoneda.DataSource = tasas;
            cmbMoneda.DisplayMember = "MonedaNombre";
            cmbMoneda.ValueMember = "TasaID";

            cmbMonedaDestino.DataSource = tasas.Copy();
            cmbMonedaDestino.DisplayMember = "MonedaNombre";
            cmbMonedaDestino.ValueMember = "TasaID";


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
                DataRowView filaOrigen = (DataRowView)cmbMoneda.SelectedItem;
                DataRowView filaDestino = (DataRowView)cmbMonedaDestino.SelectedItem;

                string tasaOrigen = filaOrigen["ValorTasa"].ToString();
                string tasaDestino = filaDestino["ValorTasa"].ToString();

                CN_Conversion calculo = new CN_Conversion();
                string resultado = calculo.ObtenerConversion(txtMonto.Text, tasaOrigen, tasaDestino);
                lblResultado.Text = resultado;
                lblre.Text = filaDestino["MonedaNombre"].ToString();

                calculo.InsertarConversion(
                    Sesion.UsuarioID.ToString(),
                    cmbMoneda.SelectedValue.ToString(),
                    cmbMonedaDestino.SelectedValue.ToString(),
                    txtMonto.Text,
                    resultado,
                    tasaOrigen,
                    tasaDestino
                );
                auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Conversion - Ejecutada");
            }
            catch (Exception ex)
            {
                auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Conversion - Fallo");
                MessageBox.Show("Conversion no realizada por: " + ex.Message);
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lblre_Click(object sender, EventArgs e)
        {

        }
    }
}
