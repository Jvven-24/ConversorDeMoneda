using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
     

    public class CN_Auditoria
    {
        private CD_Auditoria auditoriaCD = new CD_Auditoria();

        public void RegistrarAuditoria(int UsuarioID, string Accion)
        {
            auditoriaCD.Insertar(UsuarioID, Accion);
        }

        public DataTable MostrarAuditoria()
        {
            DataTable tabla = new DataTable();
            tabla = auditoriaCD.Mostrar();
            return tabla;
        }
    }   
}
