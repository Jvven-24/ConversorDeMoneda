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
        public void Insertar(string UsuarioNombre, string Contrasena)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "'Juaka', 1234";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UsuarioNombre", UsuarioNombre);
            comando.Parameters.AddWithValue("@Contrasena", Contrasena);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
    
        }
        public virtual void Editar(string UsuarioNombre, string Contrasena, int UsuarioID)
        {
            comando.Connection = conexion.ObtenerConexion();
            comando.CommandText = "EditarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@UsuarioNombre", UsuarioNombre);
            comando.Parameters.AddWithValue("@Contrasena", Contrasena);
            comando.Parameters.AddWithValue("@UsuarioID", UsuarioID);

            comando.ExecuteNonQuery();
            LimpiarCeldas();

        }

        public override void Eliminar(string storedProcedure, string parametro, int UsuarioID)
        {
            base.Eliminar("EliminarUsuario", "@UsuarioID", UsuarioID);
        }
    }


}
