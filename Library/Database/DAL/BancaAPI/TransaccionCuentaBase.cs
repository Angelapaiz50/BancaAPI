
using System.Data;
using System.Data.SqlClient;


namespace Library.Database.BLL
{
    public abstract class TransaccionCuentaBase
    {
        public DataBase.Conexion conexion;
        public TransaccionCuentaBase()
        {
            this.conexion = new DataBase.Conexion();
        }
        public SqlDataReader InsertarTransaccionCuenta(Models.BancaAPI.TransaccionCuenta modCuentaTransaccion)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                                                                    new SqlParameter("@IdTransaccion", SqlDbType.Int),
                                                                    new SqlParameter("@Tipo", SqlDbType.VarChar),
                                                                    new SqlParameter("@Monto", SqlDbType.Decimal),
                                                                    new SqlParameter("@Fecha", SqlDbType.DateTime),
                                                                    new SqlParameter("@Saldo", SqlDbType.Decimal),
                                                                    new SqlParameter("@IdCuenta", SqlDbType.Int),
                                                                    new SqlParameter("@IdCuentaDestino", SqlDbType.Int),
                                                                    new SqlParameter("@IdEstadoTransaccion", SqlDbType.Int)
                                                                    };


                sqlParameters[0].Value = modCuentaTransaccion.IdTransaccion;
                sqlParameters[1].Value = modCuentaTransaccion.Tipo;
                sqlParameters[2].Value = modCuentaTransaccion.Monto;
                sqlParameters[3].Value = modCuentaTransaccion.Fecha;
                sqlParameters[4].Value = modCuentaTransaccion.Saldo;
                sqlParameters[5].Value = modCuentaTransaccion.IdCuenta;
                sqlParameters[6].Value = modCuentaTransaccion.IdCuentaDestino;
                sqlParameters[7].Value = modCuentaTransaccion.IdEstadoTransaccion;


                return conexion.FiltrarRegistro("dbo.InsertarTransaccionCuenta", sqlParameters);
            }
            catch
            {
                throw;
            }
        }
        public SqlDataReader FiltrarTransaccionxIdCuentaorigenxTipoxMonto(
         int IdCuentaOrigen,
         String Tipo,
         decimal Monto

     )
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                                                                    new SqlParameter("@IdCuentaOrigen", SqlDbType.Int),
                                                                     new SqlParameter("@Tipo", SqlDbType.VarChar),
                                                                      new SqlParameter("@Monto", SqlDbType.Decimal)

                                                                    };


                sqlParameters[0].Value = IdCuentaOrigen;
                sqlParameters[1].Value = Tipo;
                sqlParameters[2].Value = Monto;


                return conexion.FiltrarRegistro("dbo.FiltrarTransaccionxIdCuentaorigenxTipoxMonto", sqlParameters);
            }
            catch
            {
                throw;
            }
        }

        public SqlDataReader FiltrarTransaccionxIdCuenta(
         int IdCuenta
        

     )
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                                                                    new SqlParameter("@IdCuenta", SqlDbType.Int)
                                                                    

                                                                    };


                sqlParameters[0].Value = IdCuenta;
               


                return conexion.FiltrarRegistro("dbo.FiltrarTransaccionxIdCuenta", sqlParameters);
            }
            catch
            {
                throw;
            }
        }


    }
}
