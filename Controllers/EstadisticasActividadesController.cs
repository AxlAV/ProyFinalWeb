using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyFinalWeb.Data;

namespace ProyFinalWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadisticasActividadesController : ControllerBase
    {
        private readonly TurismoGoContext _context;

        public EstadisticasActividadesController(TurismoGoContext context)
        {
            _context = context;
        }

        // GET: api/EstadisticasActividades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EstadisticasActividades>>> GetEstadisticasActividades()
        {
            return await _context.EstadisticasActividades.ToListAsync();
        }

        // GET: api/EstadisticasActividades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EstadisticasActividades>> GetEstadisticasActividades(int id)
        {
            var estadisticasActividades = await _context.EstadisticasActividades.FindAsync(id);

            if (estadisticasActividades == null)
            {
                return NotFound();
            }

            return estadisticasActividades;
        }

        // PUT: api/EstadisticasActividades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstadisticasActividades(int id, EstadisticasActividades estadisticasActividades)
        {
            if (id != estadisticasActividades.EstadisticaId)
            {
                return BadRequest();
            }

            _context.Entry(estadisticasActividades).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstadisticasActividadesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EstadisticasActividades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EstadisticasActividades>> PostEstadisticasActividades(EstadisticasActividades estadisticasActividades)
        {
            _context.EstadisticasActividades.Add(estadisticasActividades);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEstadisticasActividades", new { id = estadisticasActividades.EstadisticaId }, estadisticasActividades);
        }

        // DELETE: api/EstadisticasActividades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstadisticasActividades(int id)
        {
            var estadisticasActividades = await _context.EstadisticasActividades.FindAsync(id);
            if (estadisticasActividades == null)
            {
                return NotFound();
            }

            _context.EstadisticasActividades.Remove(estadisticasActividades);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstadisticasActividadesExists(int id)
        {
            return _context.EstadisticasActividades.Any(e => e.EstadisticaId == id);
        }
    }
}
