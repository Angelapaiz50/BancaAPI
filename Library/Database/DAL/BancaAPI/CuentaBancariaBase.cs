
using System.Data;
using System.Data.SqlClient;


namespace Library.Database.BLL
{
    public abstract class CuentaBancariaBase
    {
        public DataBase.Conexion conexion;
        public CuentaBancariaBase()
        {
            this.conexion = new DataBase.Conexion();
        }
        public SqlDataReader InsertarCuentaBancaria(Models.BancaAPI.CuentaBancaria modCuentaBancaria)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                                                                   
                                                                    new SqlParameter("@NombreCuenta", SqlDbType.VarChar),
                                                                    new SqlParameter("@Saldo", SqlDbType.Decimal),
                                                                    new SqlParameter("@IdCliente", SqlDbType.Int),
                                                                    new SqlParameter("@IdTransaccion", SqlDbType.Int),
                                                                    new SqlParameter("@NumeroCuenta", SqlDbType.VarChar),
                                                                    new SqlParameter("@Activo", SqlDbType.Bit)
                                                                    };


               
                sqlParameters[0].Value = modCuentaBancaria.NombreCuenta;
                sqlParameters[1].Value = modCuentaBancaria.Saldo;
                sqlParameters[2].Value = modCuentaBancaria.IdCliente;
                sqlParameters[3].Value = modCuentaBancaria.IdTransaccion;
                sqlParameters[4].Value = modCuentaBancaria.NumeroCuenta;
                sqlParameters[5].Value = modCuentaBancaria.Activo;


                return conexion.FiltrarRegistro("dbo.InsertarCuentaBancaria", sqlParameters);
            }
            catch
            {
                throw;
            }
        }

        public SqlDataReader ActualizarCuentaBancaria(Models.BancaAPI.CuentaBancaria modCuentaBancaria)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                                                                    
                                                                    new SqlParameter("@NombreCuenta", SqlDbType.VarChar),
                                                                    new SqlParameter("@Saldo", SqlDbType.Decimal),
                                                                    new SqlParameter("@IdCliente", SqlDbType.Int),
                                                                    new SqlParameter("@IdTransaccion", SqlDbType.Int),
                                                                    new SqlParameter("@NumeroCuenta", SqlDbType.VarChar),
                                                                    new SqlParameter("@Activo", SqlDbType.Bit)
                                                                    };


               
                sqlParameters[0].Value = modCuentaBancaria.NombreCuenta;
                sqlParameters[1].Value = modCuentaBancaria.Saldo;
                sqlParameters[2].Value = modCuentaBancaria.IdCliente;
                sqlParameters[3].Value = modCuentaBancaria.IdTransaccion;
                sqlParameters[4].Value = modCuentaBancaria.NumeroCuenta;
                sqlParameters[5].Value = modCuentaBancaria.Activo;


                return conexion.FiltrarRegistro("dbo.ActualizarCuentaBancaria", sqlParameters);
            }
            catch
            {
                throw;
            }
        }

        public SqlDataReader FiltrarCuentaBancariaxNumeroCuenta(
            String NumeroCuenta

        )
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                                                                    new SqlParameter("@NumeroCuenta", SqlDbType.Int)
                                                                  
                                                                    };


                sqlParameters[0].Value = NumeroCuenta;
             

                return conexion.FiltrarRegistro("dbo.FiltrarCuentaBancariaxNumeroCuenta", sqlParameters);
            }
            catch
            {
                throw;
            }
        }
    }
}
