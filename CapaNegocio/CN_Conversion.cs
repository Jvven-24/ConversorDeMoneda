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
        public decimal MontoOrigen { get; set; }
        public decimal MontoConvertido { get; set; }

        

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

        public decimal CalculoConversion(decimal MontoOrigen, decimal ValorTasa)
        {
           decimal MontoConvertido = MontoOrigen * ValorTasa;
            return MontoConvertido;
        }

        public void InsertarConversion(string UsuarioID, string TasaID, string MontoOrigen, string MontoConvertido, string ValorTasaUsada)
        {
            objetoCD.Insertar(Convert.ToInt32(UsuarioID), Convert.ToInt32(TasaID) , Convert.ToDecimal(MontoOrigen), Convert.ToDecimal(MontoConvertido), Convert.ToDecimal(ValorTasaUsada));

        }

        public string ObtenerConversion(string MontoOrigen, string ValorTasa)
        {
            return $"{CalculoConversion (Convert.ToDecimal(MontoOrigen), Convert.ToDecimal(ValorTasa))}";

            
        }
    }
}
