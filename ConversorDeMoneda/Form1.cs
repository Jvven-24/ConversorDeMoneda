using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace ConversorDeMoneda
{
    public partial class Form1 : Form
    {
        CN_TasaCambio objetoCN = new CN_TasaCambio();
        CN_Usuario UsuarioCN = new CN_Usuario();
        CN_Auditoria auditoria = new CN_Auditoria();

        private string UsuarioID = null;
        private string TasaID = null;
        private bool Editar = false;
        private string moduloActivo = "";


        //Configuracion del menu
        private const int MENU_COLAPSADO = 60;
        private const int MENU_EXPANDIDO = 200;
        private const int VELOCIDAD_ANIM = 30;
        private bool menuExpandiendo = false;


        //Metodo para limpiar las casillas 
        private void limpiarForm()
        {
            txtMoneda.Clear();
            txtTasaDeCambio.Clear();

        }

        //Metodos para Botones de la Tabla TasaCambio
        private void GuardarTasa()
        {
            if (Editar == false)
                try
                {
                    objetoCN.InsertarTasaCambio(txtMoneda.Text, txtTasaDeCambio.Text);
                    auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Insertar Tasa - Ejecutada");
                    MessageBox.Show("Se insertó correctamente");
                    MostrarTasaCambio();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Insertar Tasa - Fallo");
                    MessageBox.Show("No se pudo insertar: " + ex.Message);
                }

            if (Editar == true)
                try
                {
                    objetoCN.EditarTasaCambio(txtMoneda.Text, txtTasaDeCambio.Text, TasaID);
                    auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Editar Tasa - Ejecutada");
                    MessageBox.Show("Se editó correctamente");
                    MostrarTasaCambio();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Editar Tasa - Fallo");
                    MessageBox.Show("No se pudo editar: " + ex.Message);
                }
        }

        private void EditarTasa()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Editar = true;
                txtMoneda.Text = dataGridView2.CurrentRow.Cells["MonedaNombre"].Value.ToString();
                txtTasaDeCambio.Text = dataGridView2.CurrentRow.Cells["ValorTasa"].Value.ToString();
                TasaID = dataGridView2.CurrentRow.Cells["TasaID"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void EliminarTasa()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                TasaID = dataGridView2.CurrentRow.Cells["TasaID"].Value.ToString();
                auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Eliminar Tasa - Ejecutada");
                objetoCN.EliminarTasa(TasaID);
                MessageBox.Show("Eliminado correctamente");
                MostrarTasaCambio();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        //Metodos para botones de la Tabla Usuario
        private void GuardarUsuario()
        {
            if (Editar == false)
                try
                {
                    UsuarioCN.InsertarUsuario(txtMoneda.Text, txtTasaDeCambio.Text);
                    auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Insertar Usuario - Ejecutada");
                    MessageBox.Show("Se insertó correctamente");
                    MostrarUsuario();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Insertar Usuario - Fallo");
                    MessageBox.Show("No se pudo insertar: " + ex.Message);
                }

            if (Editar == true)
                try
                {
                    UsuarioCN.EditarUsuario(txtMoneda.Text, txtTasaDeCambio.Text, UsuarioID);
                    auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Editar Usuario - Ejecutada");
                    MessageBox.Show("Se editó correctamente");
                    MostrarUsuario();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Editar Usuario - Fallo");
                    MessageBox.Show("No se pudo editar: " + ex.Message);
                }
        }

        private void EditarUsuario()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Editar = true;
                txtMoneda.Text = dataGridView2.CurrentRow.Cells["UsuarioNombre"].Value.ToString();
                txtTasaDeCambio.Text = dataGridView2.CurrentRow.Cells["Rol"].Value.ToString();
                UsuarioID = dataGridView2.CurrentRow.Cells["UsuarioID"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void EliminarUsuario()
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                UsuarioID = dataGridView2.CurrentRow.Cells["UsuarioID"].Value.ToString();
                auditoria.RegistrarAuditoria(Sesion.UsuarioID, "Eliminar Usuario - Ejecutada");
                UsuarioCN.EliminarUsuario(UsuarioID);
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuario();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = MENU_COLAPSADO;
            panelbotones.Visible = false;
            
        }

        

        //Mostrar Conversion(Bitacora)
        private void MostrarConversion()
        {
            CN_Conversion objeto = new CN_Conversion();
            dataGridView2.DataSource = objeto.MostrarConversion();
        }

        //Mostrar Usuario
        private void MostrarUsuario()
        {
            CN_Usuario objeto = new CN_Usuario();
            dataGridView2.DataSource = objeto.MostrarUsuario();

        }
        //Mostrar Tasa
        private void MostrarTasaCambio()
        {
            CN_TasaCambio objeto = new CN_TasaCambio(); // Se utiliza para actualizar la vista de la tabla 
            dataGridView2.DataSource = objeto.MostrarTasa();
           
         
        }

        private void MostrarAuditoria()
        {
            CN_Auditoria auditoria = new CN_Auditoria();
            dataGridView2.DataSource = auditoria.MostrarAuditoria();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (moduloActivo)
            {
                case "Tasa": GuardarTasa(); break;
                case "Usuario": GuardarUsuario(); break;
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            switch (moduloActivo)
            {
                case "Tasa": EditarTasa(); break;
                case "Usuario": EditarUsuario(); break;
            }

        }
       
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (moduloActivo)
            {
                case "Tasa": EliminarTasa(); break;
                case "Usuario": EliminarUsuario(); break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            menuExpandiendo = true;
            timer2.Start();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            if (!panel1.ClientRectangle.Contains(
                panel1.PointToClient(Cursor.Position)))
            {
                menuExpandiendo = false;
                timer2.Start();
            } 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (menuExpandiendo)
            {
                if (panel1.Width < MENU_EXPANDIDO)
                    panel1.Width = Math.Min(panel1.Width + VELOCIDAD_ANIM, MENU_EXPANDIDO);
                else
                    timer2.Stop();

            }
            else
            {
                if (panel1.Width > MENU_COLAPSADO)
                    panel1.Width = Math.Max(panel1.Width - VELOCIDAD_ANIM, MENU_COLAPSADO);
                else
                    timer2.Stop();
            }
        }

        private void btnINICIO_Click(object sender, EventArgs e)
        {
            panelbotones.Visible = false;
            panelinicio.Visible = true;
            FormConversion conversion = new FormConversion();
            conversion.TopLevel= false;

            panelinicio.Controls.Add(conversion);
            conversion.Show();
        }

        private void btnUSUARIO_Click(object sender, EventArgs e)
        {
            lblmoneda.Visible = false;
            lblTasa.Visible = false;
            lblUsuario.Visible = true;
            lblrol.Visible = true;
            panelbotones.Visible = true;
            panelinicio.Visible = false;
            moduloActivo = "Usuario";
            MostrarUsuario();
        }

        private void btnTASACAMBIO_Click(object sender, EventArgs e)
        {
            lblUsuario.Visible = false;
            lblrol.Visible = false;
            lblmoneda.Visible = true;
            lblTasa.Visible = true;
            panelbotones.Visible = true;
            panelinicio.Visible = false;
            moduloActivo = "Tasa";
            MostrarTasaCambio();
        }

        private void btnREGISTRO_Click(object sender, EventArgs e)
        {
           
            panelbotones.Visible = false;
            panelinicio.Visible = false;
            MostrarConversion();
        }

        private void panelinicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            panelbotones.Visible = false;
            panelinicio.Visible = false;
            MostrarAuditoria();
        }
    }
}
