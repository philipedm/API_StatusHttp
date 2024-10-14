using Microsoft.AspNetCore.Mvc;

namespace API_StatusHttp.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class StatusHttpController : ControllerBase
    {
        [HttpGet(Name = "GetStatusHTTP")]
        public StatusHttp GetStatus(int cod)
        {
            var name = Enum.GetName(typeof(EnumStatusHttp), cod);
            EnumStatusHttp enumStatusHttp = (EnumStatusHttp)cod;
            var statusReturn = new StatusHttp {
                Status = cod,
                Response = name,
                Description = name != null ? enumStatusHttp.GetEnumDescription() : "Código de status inexistente"
            };

            return statusReturn;
        }
    }
}
