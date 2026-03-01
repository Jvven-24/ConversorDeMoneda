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
    public class CN_TasaCambio
    {
        private CD_TasaCambio objetoCD = new CD_TasaCambio();

        public DataTable MostrarTasa()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarTasaCambio( string MonedaNombre, string ValorTasa)
        {
            objetoCD.Insertar(MonedaNombre, Convert.ToDouble(ValorTasa));

        }
        public void EditarTasaCambio( string MonedaNombre, string ValorTasa, string TasaID)
        {
            objetoCD.Editar(MonedaNombre, Convert.ToDouble(ValorTasa), Convert.ToInt32(TasaID));
        }
        
        public void EliminarTasa(string TasaID)
        {
            objetoCD.Eliminar(Convert.ToInt32(TasaID));
        }
    }
}
