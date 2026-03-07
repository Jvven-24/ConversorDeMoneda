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

        public void InsertarUsuario( string UsuarioNombre, string Contrasena)
        {
            objetoCD.Insertar(UsuarioNombre, Contrasena);
        }
        public void EditarUsuario(string UsuarioNombre, string Contrasena, string UsuarioID)
        {
            objetoCD.Editar(UsuarioNombre, Contrasena, Convert.ToInt32(UsuarioID));
        }

        public void EliminarUsuario(int TasaID)
        {
            objetoCD.Eliminar(Convert.ToInt32(TasaID));
        }
    }

}
