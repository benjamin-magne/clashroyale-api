using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClashRoyaleApi.Models;

namespace ClashRoyaleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TroopController : ControllerBase
    {
        private readonly TroopContext _context;

        public TroopController(TroopContext context)
        {
            _context = context;
        }

        // GET: api/Troop
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Troop>>> GetTroops()
        {
            return await _context.Troops.ToListAsync();
        }

        // GET: api/Troop/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Troop>> GetTroop(int id)
        {
            var troop = await _context.Troops.FindAsync(id);

            if (troop == null)
            {
                return NotFound();
            }

            return troop;
        }

        // PUT: api/Troop/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTroop(int id, Troop troop)
        {
            if (id != troop.Id)
            {
                return BadRequest();
            }

            _context.Entry(troop).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TroopExists(id))
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

        // POST: api/Troop
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Troop>> PostTroop(Troop troop)
        {
            _context.Troops.Add(troop);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTroop", new { id = troop.Id }, troop);
        }

        // DELETE: api/Troop/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTroop(int id)
        {
            var troop = await _context.Troops.FindAsync(id);
            if (troop == null)
            {
                return NotFound();
            }

            _context.Troops.Remove(troop);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TroopExists(int id)
        {
            return _context.Troops.Any(e => e.Id == id);
        }
    }
}
