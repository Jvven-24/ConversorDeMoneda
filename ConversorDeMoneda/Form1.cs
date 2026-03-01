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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarTasaCambio();

        }
        //Mostrar Tasa
        private void MostrarTasaCambio()
        {
            CN_TasaCambio objeto = new CN_TasaCambio(); // Se utiliza para actualizar la vista de la tabla 
            dataGridView2.DataSource = objeto.MostrarTasa();
         
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
    }
}
