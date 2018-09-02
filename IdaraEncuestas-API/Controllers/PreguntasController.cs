using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdaraEncuestas_API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdaraEncuestas_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PreguntasController : ControllerBase
    {
        private readonly DataContext _context;
        public PreguntasController(DataContext context)
        {
            _context = context;
        }

        // GET api/preguntas
        [HttpGet]
        public async Task<ActionResult> GetPreguntas()
        {
            var preguntas = await _context.Preguntas.ToListAsync();

            return Ok(preguntas);
            
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var pregunta = _context.Preguntas.FirstOrDefault(a => a.Id == id);

            return Ok(pregunta);
        }

        // POST api/preguntas
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/preguntas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/preguntas/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
