namespace Inputs.BancaCliente
{
    public class CuentaClienteAPI
    {

        public int IdCliente { get; set; }
        public int Nombre { get; set; }
        public string? TelefonoCliente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Sexo { get; set; }
        public string? Direccion { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Ingresos { get; set; }
        public bool Activo { get; set; }
    }
}
