using Database;

using System.Data.SqlClient;


namespace Library.Database.BLL.BancaAPI
{
    public class ClienteBase
    {

        public DAL.Cliente dalCliente;
        public ClienteBase()
        {
            dalCliente = new DAL.Cliente();
        }

        public Models.BancaAPI.Cliente InsertarClienteBanca(Models.BancaAPI.Cliente modClienteBanca)
        {
            try
            {
                dalCliente.conexion.AbrirConexion();

                SqlDataReader sqlDataReader = dalCliente.InsertarClienteBanca(modClienteBanca);

                modClienteBanca = ConversorClases.ConvertModel<Models.BancaAPI.Cliente>(sqlDataReader);

                dalCliente.conexion.CerrarConexion();

                return modClienteBanca;
            }
            catch
            {
                throw;
            }
        }
    }
}
