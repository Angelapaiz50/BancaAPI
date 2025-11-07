namespace Inputs.BancaCliente
{
    public class CuentaBancariaAPI
    {

        public Int32 IdCuentaOrigen { get; set; }
        public String? NombreCuenta { get; set; }
        public Decimal? Saldo { get; set; }
        public Int32 IdCliente { get; set; }
        public Int32 IdTransaccion { get; set; }
        public String? NumeroCuenta { get; set; }
        public Boolean Activo { get; set; }
    }
}
