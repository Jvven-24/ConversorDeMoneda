using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Auditoria : CD_Base
    {
        public override DataTable Mostrar()
        {
            return EjecutarMostrar("MostrarAuditoria");
        }

        public void Insertar(int UsuarioID, string Accion)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "InsertarAuditoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UsuarioID", UsuarioID);
            comando.Parameters.AddWithValue("@Accion", Accion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
