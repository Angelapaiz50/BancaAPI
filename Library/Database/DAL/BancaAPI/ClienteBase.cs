
using System.Data;
using System.Data.SqlClient;


namespace Library.Database.BLL
{
    public abstract class ClienteBase
    {
        public DataBase.Conexion conexion;
        public ClienteBase()
        {
            this.conexion = new DataBase.Conexion();
        }
        public SqlDataReader InsertarClienteBanca(Models.BancaAPI.Cliente modClienteBanca)
        {
            try
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                                                                    
                                                                    new SqlParameter("@Nombre", SqlDbType.VarChar),
                                                                    new SqlParameter("@TelefonoCliente", SqlDbType.VarChar),
                                                                    new SqlParameter("@FechaNacimiento", SqlDbType.DateTime),
                                                                    new SqlParameter("@Sexo", SqlDbType.Bit),
                                                                    new SqlParameter("@Direccion", SqlDbType.VarChar),
                                                                    new SqlParameter("@CorreoElectronico", SqlDbType.VarChar),
                                                                    new SqlParameter("@Ingresos", SqlDbType.VarChar),
                                                                    new SqlParameter("@Activo", SqlDbType.Bit)
                                                                    };


               
                sqlParameters[0].Value = modClienteBanca.Nombre;
                sqlParameters[1].Value = modClienteBanca.TelefonoCliente;
                sqlParameters[2].Value = modClienteBanca.FechaNacimiento;
                sqlParameters[3].Value = modClienteBanca.Sexo;
                sqlParameters[4].Value = modClienteBanca.Direccion;
                sqlParameters[5].Value = modClienteBanca.CorreoElectronico;
                sqlParameters[6].Value = modClienteBanca.Ingresos;
                sqlParameters[7].Value = modClienteBanca.Activo;


                return conexion.FiltrarRegistro("dbo.InsertarClienteBanca", sqlParameters);
            }
            catch
            {
                throw;
            }
        }
    }
}
