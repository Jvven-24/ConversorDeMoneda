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
        private string TasaID = null;
        private bool Editar = false;
        private const int MENU_COLAPSADO = 60;
        private const int MENU_EXPANDIDO = 200;
        private const int VELOCIDAD_ANIM = 30;
        private bool menuExpandiendo = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Width = MENU_COLAPSADO;
            btnEditar.Visible = false;
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;


            label1.Visible = false;
            label2.Visible = false;
            txtMoneda.Visible = false;
            txtTasaDeCambio.Visible = false;    
            
        }

        private void Botones()
        {
            btnEditar.Visible = true;
            btnGuardar.Visible = true;
            btnEliminar.Visible = true;


            label1.Visible = true;
            label2.Visible = true;
            txtMoneda.Visible = true;
            txtTasaDeCambio.Visible = true;
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
            Botones();
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR TASA DE CAMBIO
            if (Editar == false) 
            try
            {
                objetoCN.InsertarTasaCambio(txtMoneda.Text, txtTasaDeCambio.Text);
                MessageBox.Show("se inserto correctamente");
                MostrarTasaCambio();
                    limpiarFormTasaCambio();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
            }
            // EDITAR TASA DE CAMBIO
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarTasaCambio(txtMoneda.Text, txtTasaDeCambio.Text, TasaID);
                    MessageBox.Show("se edito correctamente");
                    MostrarTasaCambio();
                    limpiarFormTasaCambio();
                    Editar = false;

                }

                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Editar = true;
                txtMoneda.Text = dataGridView2.CurrentRow.Cells["MonedaNombre"].Value.ToString();
                txtTasaDeCambio.Text = dataGridView2.CurrentRow.Cells["ValorTasa"].Value.ToString();
                TasaID = dataGridView2.CurrentRow.Cells["TasaID"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }
        private void limpiarFormTasaCambio()
        {
            txtMoneda.Clear();
            txtTasaDeCambio.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
              TasaID = dataGridView2.CurrentRow.Cells["TasaID"].Value.ToString() ;
              objetoCN.EliminarTasa(TasaID);
                MessageBox.Show("Eliminado correctamente");
                MostrarTasaCambio();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
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
            panelinicio.Visible = true;
            FormConversion conversion = new FormConversion();
            conversion.TopLevel= false;

            panelinicio.Controls.Add(conversion);
            conversion.Show();
        }

        private void btnUSUARIO_Click(object sender, EventArgs e)
        {
            panelinicio.Visible = false;
            MostrarUsuario();
        }

        private void btnTASACAMBIO_Click(object sender, EventArgs e)
        {
            panelinicio.Visible = false;
            MostrarTasaCambio();
        }

        private void btnREGISTRO_Click(object sender, EventArgs e)
        {
            panelinicio.Visible = false;
            MostrarConversion();
        }
    }
}
