namespace Inputs.BancaCliente
{
    public class TransaccionCuentaAPI
    {

        public Int32 IdTransaccion { get; set; }
        public String? Tipo { get; set; }
        public Decimal? Monto { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Saldo { get; set; }
        public Int32? IdCuenta { get; set; }
        public Int32? IdCuentaDestino { get; set; }
        public Int32? IdCuentaOrigen { get; set; }
        public Int32? IdEstadoTransaccion { get; set; }

        public String? NumeroCuenta { get; set; }

    }
}
