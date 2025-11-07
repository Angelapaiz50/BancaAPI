


using BancaAPI.Response;
using Microsoft.AspNetCore.Mvc;

namespace PortalCliente.Controllers
{

    [ApiController]
    [Route("Api/[Controller]")]
    public class BancaController : ControllerBase
    {


        public BancaController(
            IHttpContextAccessor httpContextAccessor

            )
        {

        }



        [HttpPost]
        [Route("InsertarClienteBanca")]

        public IActionResult InsertarClienteBanca([FromBody] Inputs.BancaCliente.CuentaClienteAPI cuentaClienteAPI)


        {

            try
            {

                Library.Database.BLL.BancaAPI.Cliente bllCliente = new Library.Database.BLL.BancaAPI.Cliente();


                Models.BancaAPI.Cliente modCliente = new Models.BancaAPI.Cliente
                {
                    Nombre = cuentaClienteAPI.Nombre,
                    TelefonoCliente = cuentaClienteAPI.TelefonoCliente,
                    FechaNacimiento = cuentaClienteAPI.FechaNacimiento,
                    Sexo = cuentaClienteAPI.Sexo,
                    Direccion = cuentaClienteAPI.Direccion,
                    CorreoElectronico = cuentaClienteAPI.CorreoElectronico,
                    Ingresos = cuentaClienteAPI.Ingresos,
                    Activo = true,

                };

                bllCliente.InsertarClienteBanca(modCliente);

                return Ok(new
                {
                    exito = true,
                    mensaje = "Registro agregado con éxito",
                    dato = modCliente
                });
            }
            catch (Exception e)
            {
                
                return StatusCode(500, new
                {
                    exito = false,
                    mensaje = $"Ocurrió un error: {e.Message}",
                    detalle = e.StackTrace
                });
            }
        }


        [HttpPost]
        [Route("InsertarCuentaBancaria")]

        public IActionResult InsertarCuentaBancaria([FromBody] Inputs.BancaCliente.CuentaBancariaAPI CuentaBancariaAPI)

        {

            try
            {

                Library.Database.BLL.BancaAPI.CuentaBancaria bllCuentaBancaria = new Library.Database.BLL.BancaAPI.CuentaBancaria();


                Models.BancaAPI.CuentaBancaria modCuentaBancaria = new Models.BancaAPI.CuentaBancaria
                {
                    NombreCuenta = CuentaBancariaAPI.NombreCuenta,
                    Saldo = CuentaBancariaAPI.Saldo,
                    IdCliente = CuentaBancariaAPI.IdCliente,
                    IdTransaccion = CuentaBancariaAPI.IdTransaccion,
                    Activo = true,

                };

                bllCuentaBancaria.InsertarCuentaBancaria(modCuentaBancaria);

                return Ok(new
                {
                    exito = true,
                    mensaje = "Registro agregado con éxito",
                    dato = modCuentaBancaria
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    exito = false,
                    mensaje = $"Ocurrió un error: {e.Message}",
                    detalle = e.StackTrace
                });
            }
        }



        [HttpGet]
        [Route("ConsultarSaldoCuentaBancaria/{numeroCuenta}")]
        public IActionResult ConsultarSaldoCuentaBancaria(string numeroCuenta)
        {
            try
            {
                Library.Database.BLL.BancaAPI.CuentaBancaria bllCuentaBancaria = new Library.Database.BLL.BancaAPI.CuentaBancaria();

                List<Models.BancaAPI.CuentaBancaria> listaSaldoCuenta =
                    bllCuentaBancaria.FiltrarCuentaBancariaxNumeroCuenta(numeroCuenta);

                if (listaSaldoCuenta == null || listaSaldoCuenta.Count == 0)
                {
                    return NotFound(new
                    {
                        exito = false,
                        mensaje = "Cuenta no encontrada o inactiva"
                    });
                }

                var saldo = listaSaldoCuenta[0].Saldo;

                return Ok(new
                {
                    exito = true,
                    mensaje = "Saldo obtenido con éxito",
                    saldo = saldo
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    exito = false,
                    mensaje = ex.Message,
                    detalle = ex.StackTrace
                });
            }
        }


      



    }
}










