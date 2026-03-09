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

        public virtual void Insertar(int UsuarioID, int TasaID, decimal MontoOrigen, decimal MontoConvertido, decimal ValorTasaUsada)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "InsertarConversion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UsuarioID", UsuarioID);
            comando.Parameters.AddWithValue("@TasaID", TasaID);
            comando.Parameters.AddWithValue("@MontoOrigen", MontoOrigen);
            comando.Parameters.AddWithValue("@MontoConvertido", MontoConvertido);
            comando.Parameters.AddWithValue("@ValorTasaUsada", ValorTasaUsada);

            comando.ExecuteNonQuery();
            LimpiarCeldas();

        }
        
    }
}
