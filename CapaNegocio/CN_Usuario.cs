using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objetoCD = new CD_Usuario();

        public DataTable MostrarUsuario()
        {
            DataTable tablaUsuario = new DataTable();
            tablaUsuario = objetoCD.Mostrar();
            return tablaUsuario;
    
        }

        public void InsertarUsuario( string UsuarioNombre, string Rol)
        {
            objetoCD.Insertar(UsuarioNombre, Rol);
        }
        public void EditarUsuario(string UsuarioNombre, string Rol, string UsuarioID)
        {
            objetoCD.Editar(UsuarioNombre, Rol, Convert.ToInt32(UsuarioID));
        }

        public void EliminarUsuario(int UsuarioID)
        {
            objetoCD.Eliminar(Convert.ToInt32(UsuarioID));
        }
    }

    public static class Sesion
    {
        public static int UsuarioID { get; set; }
        
        public static string UsuarioNombre { get; set; }
        public static string Rol { get; set; }
    }
}
