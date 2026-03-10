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
        public FormConversion()
        {
            InitializeComponent();
        }

        private void FormConversion_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Sesion.UsuarioNombre + " · " + Sesion.Rol;

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
            CN_Conversion calculo = new CN_Conversion();
            calculo.ObtenerConversion(txtMonto.Text, lblTasa.Text);
            lblResultado.Text = $"{calculo.MontoConvertido}";


        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
