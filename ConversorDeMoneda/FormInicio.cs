using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConversorDeMoneda
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {
            CN_Usuario objeto = new CN_Usuario();
            cmbUsuario.DataSource = objeto.MostrarUsuario();
            cmbUsuario.DisplayMember = "UsuarioNombre";
            cmbUsuario.ValueMember = "UsuarioID";

        }
        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            Sesion.UsuarioID = Convert.ToInt32(cmbUsuario.SelectedValue);
            Sesion.UsuarioNombre = cmbUsuario.Text;
            Form1 principal = new Form1();
            principal.Show();
            this.Hide();
        }

       
    }
}
