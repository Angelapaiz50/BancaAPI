using Database;

using System.Data.SqlClient;


namespace Library.Database.BLL.BancaAPI
{
    public class TransaccionCuentaBase
    {

        public DAL.TransaccionCuenta dalTransaccionCuenta;
        public TransaccionCuentaBase()
        {
            dalTransaccionCuenta = new DAL.TransaccionCuenta();
        }

        public Models.BancaAPI.TransaccionCuenta InsertarTransaccionCuenta(Models.BancaAPI.TransaccionCuenta modTransaccionCuenta)
        {
            try
            {
                dalTransaccionCuenta.conexion.AbrirConexion();

                SqlDataReader sqlDataReader = dalTransaccionCuenta.InsertarTransaccionCuenta(modTransaccionCuenta);

                modTransaccionCuenta = ConversorClases.ConvertModel<Models.BancaAPI.TransaccionCuenta>(sqlDataReader);

                dalTransaccionCuenta.conexion.CerrarConexion();

                return modTransaccionCuenta;
            }
            catch
            {
                throw;
            }
        }



        public Models.BancaAPI.TransaccionCuenta FiltrarTransaccionxIdCuentaorigenxTipoxMonto(int IdCuentaOrigen,String Tipo,decimal Monto)
        {
            try
            {
                Models.BancaAPI.TransaccionCuenta modTransaccionCuenta = new Models.BancaAPI.TransaccionCuenta();
                dalTransaccionCuenta.conexion.AbrirConexion();

                SqlDataReader sqlDataReader = dalTransaccionCuenta.FiltrarTransaccionxIdCuentaorigenxTipoxMonto(
               IdCuentaOrigen,  Tipo,  Monto
                );

                modTransaccionCuenta = ConversorClases.ConvertModel<Models.BancaAPI.TransaccionCuenta>(sqlDataReader);

                dalTransaccionCuenta.conexion.CerrarConexion();

                return modTransaccionCuenta;
            }
            catch
            {
                throw;
            }
        }

        public Models.BancaAPI.TransaccionCuenta FiltrarTransaccionxIdCuenta(int IdCuenta)
        {
            try
            {
                Models.BancaAPI.TransaccionCuenta modTransaccionCuenta = new Models.BancaAPI.TransaccionCuenta();
                dalTransaccionCuenta.conexion.AbrirConexion();

                SqlDataReader sqlDataReader = dalTransaccionCuenta.FiltrarTransaccionxIdCuenta(
               IdCuenta
                );

                modTransaccionCuenta = ConversorClases.ConvertModel<Models.BancaAPI.TransaccionCuenta>(sqlDataReader);

                dalTransaccionCuenta.conexion.CerrarConexion();

                return modTransaccionCuenta;
            }
            catch
            {
                throw;
            }
        }
    }
}
