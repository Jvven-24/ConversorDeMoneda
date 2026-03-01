using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        // 1. ConnectionString - Cambia esto según tu servidor
        private string connectionString = "Server=.; Database=ConversorDeMoneda; Integrated Security=true;";

        // 2. Método que devuelve una conexión abierta
        public SqlConnection ObtenerConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar: " + ex.Message);
            }

        }

        // 3. Método para probar la conexión
        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection con = ObtenerConexion())
                {
                    return con.State == System.Data.ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }


        }

        //4.Metodo para cerrar conexion
        public SqlConnection CerrarConexion()
        {
            if (ObtenerConexion().State == System.Data.ConnectionState.Open)
                ObtenerConexion().Close();
            return ObtenerConexion();

        }
    }
}