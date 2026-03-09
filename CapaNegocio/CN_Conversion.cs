using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class CN_Conversion
    {
        public int UsuarioID;
        public int TasaID;
        public decimal MontoOrigen;
        public decimal MontoConvertido;

        private CD_Conversion objetoCD;

        public CN_Conversion()
        {
            objetoCD = new CD_Conversion();
        }

        public DataTable MostrarConversion()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public decimal CalculoConversion(decimal MontoOrigen,  decimal MontoConvertido, decimal ValorTasa)
        {
            MontoConvertido = MontoOrigen * ValorTasa;
            return MontoConvertido;
        }

        public void InsertarConversion(string UsuarioID, string TasaID, string MontoOrigen, string MontoConvertido)
        {
            objetoCD.Insertar(Convert.ToInt32(UsuarioID), Convert.ToInt32(TasaID) , Convert.ToDecimal(MontoOrigen), Convert.ToDecimal(MontoConvertido));

        }
    }
}
