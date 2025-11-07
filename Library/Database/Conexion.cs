using System;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Conexion
    {
        string SICTConnectionString = "";

        public SqlConnection _conexion = new SqlConnection();

        public Conexion()
        {
#pragma warning disable CS8601 // Posible asignación de referencia nula
            this.SICTConnectionString = Environment.GetEnvironmentVariable("SICTConnection");
#pragma warning restore CS8601 // Posible asignación de referencia nula

            _conexion.ConnectionString = SICTConnectionString;
        }

        public void AbrirConexion()
        {
            try
            {
                _conexion.Open();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void CerrarConexion()
        {
            try
            {
                _conexion.Close();
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public SqlDataReader FiltrarRegistro(String procedimientoAlmacenado,
                                             SqlParameter[] sqlParameterCollection)
        {
            try
            {
                using SqlCommand sqlCommand = new SqlCommand(procedimientoAlmacenado, _conexion);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                Console.WriteLine($"Ejecutando procedimiento: {procedimientoAlmacenado}");

                if (sqlParameterCollection != null)
                    sqlCommand.Parameters.AddRange(sqlParameterCollection);

                return sqlCommand.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
