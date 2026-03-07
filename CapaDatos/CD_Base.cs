using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace CapaDatos
{
    public abstract class CD_Base
    {
        protected CD_Conexion conexion = new CD_Conexion();
        protected SqlDataReader leer;
        protected DataTable tabla = new DataTable();
        protected SqlCommand comando = new SqlCommand();


        public abstract DataTable Mostrar();
       
        protected virtual DataTable EjecutarMostrar(string storedProcudure)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = storedProcudure;
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        protected void LimpiarCeldas()
        {
            comando.Parameters.Clear();
        }

        public virtual void Eliminar(string storedProcedure, string parametro, int id)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = storedProcedure;
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue(parametro, id);
            comando.ExecuteNonQuery();
            LimpiarCeldas();
        }
       
    }
     
    
}
