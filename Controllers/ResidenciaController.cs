using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionamentoApi.Data;
using RelacionamentoApi.Models;

namespace RelacionamentoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidenciaController : ControllerBase
    {
        private readonly AppDbContext _contexto;

        public ResidenciaController(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<List<Casa>>> BuscarCasas()
        {
            var casas = await _contexto.Casas.Include(e => e.Endereco)
                                             .Include(q => q.Quartos)
                                             .Include(m => m.Moradores)
                                             .ToListAsync();

            return Ok(casas);
        }



    }
}
