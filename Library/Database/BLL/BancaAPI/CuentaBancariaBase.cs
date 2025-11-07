using Database;

using System.Data.SqlClient;


namespace Library.Database.BLL.BancaAPI
{
    public class CuentaBancariaBase
    {

        public DAL.CuentaBancaria dalCuentaBancaria;
        public CuentaBancariaBase()
        {
            dalCuentaBancaria = new DAL.CuentaBancaria();
        }

        public Models.BancaAPI.CuentaBancaria InsertarCuentaBancaria(Models.BancaAPI.CuentaBancaria modCuentaBancaria)
        {
            try
            {
                dalCuentaBancaria.conexion.AbrirConexion();

                SqlDataReader sqlDataReader = dalCuentaBancaria.InsertarCuentaBancaria(modCuentaBancaria);

                modCuentaBancaria = ConversorClases.ConvertModel<Models.BancaAPI.CuentaBancaria>(sqlDataReader);

                dalCuentaBancaria.conexion.CerrarConexion();

                return modCuentaBancaria;
            }
            catch
            {
                throw;
            }
        }

        public Models.BancaAPI.CuentaBancaria ActualizarCuentaBancaria(Models.BancaAPI.CuentaBancaria modCuentaBancaria)
        {
            try
            {
                dalCuentaBancaria.conexion.AbrirConexion();

                SqlDataReader sqlDataReader = dalCuentaBancaria.ActualizarCuentaBancaria(modCuentaBancaria);

                modCuentaBancaria = ConversorClases.ConvertModel<Models.BancaAPI.CuentaBancaria>(sqlDataReader);

                dalCuentaBancaria.conexion.CerrarConexion();

                return modCuentaBancaria;
            }
            catch
            {
                throw;
            }
        }

        public List<Models.BancaAPI.CuentaBancaria> FiltrarCuentaBancariaxNumeroCuenta(String NumeroCuenta)
        {
            try
            {
                List<Models.BancaAPI.CuentaBancaria> listaSaldoCuenta = new List<Models.BancaAPI.CuentaBancaria>();
                dalCuentaBancaria.conexion.AbrirConexion();

                SqlDataReader sqlDataReader = dalCuentaBancaria.FiltrarCuentaBancariaxNumeroCuenta(NumeroCuenta);
                listaSaldoCuenta = ConversorClases.ConvertDataTable<Models.BancaAPI.CuentaBancaria>(sqlDataReader);

                dalCuentaBancaria.conexion.CerrarConexion();

                return listaSaldoCuenta;
            }
            catch
            {
                throw;
            }
        }
    }
}
