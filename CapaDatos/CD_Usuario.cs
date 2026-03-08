using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuario : CD_Base
    {
        
        public override DataTable Mostrar()
        {
            return EjecutarMostrar("MostrarUsuario");  
        }
        public void Insertar(string UsuarioNombre, string Rol)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "InsertarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UsuarioNombre", UsuarioNombre);
            comando.Parameters.AddWithValue("@Rol", Rol);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
    
        }
        public virtual void Editar(string UsuarioNombre, string Rol, int UsuarioID)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "EditarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UsuarioNombre", UsuarioNombre);
            comando.Parameters.AddWithValue("@Rol", Rol);
            comando.Parameters.AddWithValue("@UsuarioID", UsuarioID);

            comando.ExecuteNonQuery();
            LimpiarCeldas();

        }

        public void Eliminar(int UsuarioID)
        {
            base.Eliminar("EliminarUsuario", "@UsuarioID", UsuarioID);
        }
    }


}
