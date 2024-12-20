using DesafioBancoMaster.Data;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBancoMaster.Controllers
{
    [ApiController]
    [Route("api/rotas")]
    public class RotasController : ControllerBase
    {
        private readonly ApplicationDbContext DbContext;

        public RotasController(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        [HttpGet]
        public IActionResult BuscaTodasRotas()
        {
            var TodasRotas = DbContext.Rotas.ToList();
            return Ok(TodasRotas);        
        }
    }
}
