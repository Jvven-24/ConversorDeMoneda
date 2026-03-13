using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Conversion : CD_Base
    {

        public override DataTable Mostrar()
        {
            return EjecutarMostrar("MostrarConversion");
        }

        public virtual void Insertar(int UsuarioID, int TasaOrigenID, int TasaDestinoID, decimal MontoOrigen, decimal MontoConvertido, decimal ValorTasaOrigen, decimal ValorTasaDestino)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "InsertarConversion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UsuarioID", UsuarioID);
            comando.Parameters.AddWithValue("@TasaOrigenID", TasaOrigenID);
            comando.Parameters.AddWithValue("@TasaDestinoID", TasaDestinoID);
            comando.Parameters.AddWithValue("@MontoOrigen", MontoOrigen);
            comando.Parameters.AddWithValue("@MontoConvertido", MontoConvertido);
            comando.Parameters.AddWithValue("@ValorTasaOrigen", ValorTasaOrigen);
            comando.Parameters.AddWithValue("@ValorTasaDestino", ValorTasaDestino);
           
            comando.ExecuteNonQuery();
            LimpiarCeldas();

        }
        
    }
}
