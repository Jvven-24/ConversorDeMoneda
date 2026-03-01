using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CD_TasaCambio
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
           
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "MostrarTasaCambio";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;


        }
        public void Insertar(string MonedaNombre, double ValorTasa)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "InsertarTasa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@MonedaNombre",MonedaNombre);
            comando.Parameters.AddWithValue("@ValorTasa",ValorTasa);
            
            comando.ExecuteNonQuery();
            
            comando.Parameters.Clear();

        }
        public void Editar(string MonedaNombre, double ValorTasa, int TasaID)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "EditarTasa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@MonedaNombre", MonedaNombre);
            comando.Parameters.AddWithValue("@ValorTasa", ValorTasa);
            comando.Parameters.AddWithValue("@TasaID", TasaID);
           
            comando.ExecuteNonQuery();
            
            comando.Parameters.Clear();

        }

        public void Eliminar(int TasaID)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "EliminarTasa";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("TasaID", TasaID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
