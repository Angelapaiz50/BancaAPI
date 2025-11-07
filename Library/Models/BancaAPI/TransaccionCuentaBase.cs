using System;

namespace Models.BancaAPI
{
    public class TransaccionCuentaBase
    {
        public Int32 IdTransaccion { get; set; }
        public String? Tipo { get; set; }
        public Decimal? Monto { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Saldo { get; set; }
        public Int32? IdCuenta { get; set; }
        public Int32? IdCuentaDestino { get; set; }
        public Int32? IdEstadoTransaccion { get; set; }

    }
}
