#region Documentación
/************************************************************************************************************
 * Unidad        : Cli  entesController                                                                      
 * Descripcion   : Clase usada como controlador para responder al cliente.  
 ***********************************************************************************************************/
#endregion Documentación

using ClientesQuemados.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ClientesQuemados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            ClientesRepository clienteRepository = new ClientesRepository();
            return Ok(clienteRepository.ObtenerClientes());
        }
    }
}
