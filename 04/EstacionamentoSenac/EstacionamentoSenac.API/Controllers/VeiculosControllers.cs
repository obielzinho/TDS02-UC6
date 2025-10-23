using EstacionamentoSenac.API.D;
using EstacionamentoSenac.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace EstacionamentoSenac.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosControllers : ControllerBase
    {
        private AppDbContext _context;

        public VeiculosControllers(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Veiculo> GetVeiculos()
        {

            return _context.Veiculos.ToList();
        }

      



    }
}
