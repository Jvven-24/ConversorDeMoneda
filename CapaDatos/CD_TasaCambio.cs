using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CD_TasaCambio : CD_Base
    {
       
        public override  DataTable Mostrar()
        {
            return EjecutarMostrar("MostrarTasaCambio");
          
        }

        public virtual void Insertar(string MonedaNombre, double ValorTasa)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "InsertarTasa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@MonedaNombre",MonedaNombre);
            comando.Parameters.AddWithValue("@ValorTasa",ValorTasa);
            
            comando.ExecuteNonQuery();
            LimpiarCeldas();
            

        }
        public virtual void Editar(string MonedaNombre, double ValorTasa, int TasaID)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "EditarTasa";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@MonedaNombre", MonedaNombre);
            comando.Parameters.AddWithValue("@ValorTasa", ValorTasa);
            comando.Parameters.AddWithValue("@TasaID", TasaID);
           
            comando.ExecuteNonQuery();
            LimpiarCeldas(); 
          
        }

        public void Eliminar(int TasaID )
        {
            Eliminar("EliminarTasa", "@TasaID", TasaID);
        }
    }
}
