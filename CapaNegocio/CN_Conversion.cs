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

        public decimal CalculoConversion(decimal MontoOrigen, decimal TasaOrigen, decimal TasaDestino)
        {
            return (MontoOrigen * TasaOrigen) / TasaDestino;
        }

        public void InsertarConversion(string UsuarioID, string TasaOrigenID, string TasaDestinoID, string MontoOrigen, string MontoConvertido, string ValorTasaOrigen, string ValorTasaDestino)
        {
            objetoCD.Insertar(
                Convert.ToInt32(UsuarioID),
                Convert.ToInt32(TasaOrigenID),
                Convert.ToInt32(TasaDestinoID),
                Convert.ToDecimal(MontoOrigen),
                Convert.ToDecimal(MontoConvertido),
                Convert.ToDecimal(ValorTasaOrigen),
                Convert.ToDecimal(ValorTasaDestino)
            );
        }

        public string ObtenerConversion(string MontoOrigen, string TasaOrigen, string TasaDestino)
        {
            return CalculoConversion(
                Convert.ToDecimal(MontoOrigen),
                Convert.ToDecimal(TasaOrigen),
                Convert.ToDecimal(TasaDestino)
            ).ToString("N2");
        }
    }
}
