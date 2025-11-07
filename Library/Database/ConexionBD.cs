using Static;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Database
{
    public class Conexion
    {
        string BancaAPIConnectionString = "";
        string SICTConnectionString = "";
        string SISGOConnectionString = "";
        string TrazabilidadConnectionString = "";

        public SqlConnection _conexionBancaAPI = new SqlConnection();
        public SqlConnection _conexionSICT = new SqlConnection();
        public SqlConnection _conexionSISGO = new SqlConnection();
        public SqlConnection _conexionTrazabilidad = new SqlConnection();

        internal void CerrarConexion()
        {
            throw new NotImplementedException();
        }

        public Conexion()
        {
            this.BancaAPIConnectionString = Environment.GetEnvironmentVariable("BancaAPIConnection")!;
            this.SICTConnectionString = Environment.GetEnvironmentVariable("SICTConnection")!;
            this.SISGOConnectionString = Environment.GetEnvironmentVariable("SISGOConnection")!;
            this.TrazabilidadConnectionString = Environment.GetEnvironmentVariable("TrazabilidadConnection")!;

            _conexionBancaAPI.ConnectionString = BancaAPIConnectionString;
            _conexionSICT.ConnectionString = SICTConnectionString;
            _conexionSISGO.ConnectionString = SISGOConnectionString;
            _conexionTrazabilidad.ConnectionString = TrazabilidadConnectionString;
        }

        public void AbrirConexion(Int16 database)
        {
            try
            {
                switch (database)
                {
                    case DatabaseEnumerable.BancaAPI:
                        _conexionBancaAPI.Open();
                        break;
                   
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public void CerrarConexion(Int16 database)
        {
            try
            {
                switch (database)
                {
                    case DatabaseEnumerable.BancaAPI:
                        _conexionBancaAPI.Open();
                        break;
                  
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        private SqlConnection obtenerBaseDato(Int16 database)

        {
            switch (database)
            {
                case DatabaseEnumerable.BancaAPI:
                    return _conexionBancaAPI;
              
                default:
                    return _conexionSICT;
            }
        }
        public SqlDataReader FiltrarRegistro(
            Int16 database,
            String procedimientoAlmacenado,
            SqlParameter[] sqlParameterCollection
            )
        {
            SqlConnection conexion = obtenerBaseDato(database);

            using SqlCommand sqlCommand = new SqlCommand(procedimientoAlmacenado, conexion);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            Console.WriteLine($"Ejecutando procedimiento: {procedimientoAlmacenado}");

            if (sqlParameterCollection != null)
                sqlCommand.Parameters.AddRange(sqlParameterCollection);

            return sqlCommand.ExecuteReader();
        }
    }
}
