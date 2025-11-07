using System;

namespace Models.BancaAPI
{
    public class ClienteBase
    {
        public Int32 IdCliente { get; set; }
        public Int32 Nombre { get; set; }
        public String? TelefonoCliente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Boolean Sexo { get; set; }
        public String? Direccion { get; set; }
        public String? CorreoElectronico { get; set; }
        public string? Ingresos { get; set; }
        public Boolean Activo { get; set; }
       
    }
}
