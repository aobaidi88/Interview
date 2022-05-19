using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AObaidiP5.Server;
using AObaidiP5.Shared;

namespace AObaidiP5.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnowBoardsController : ControllerBase
    {
        private readonly SnowBoardDbContext _context;

        public SnowBoardsController(SnowBoardDbContext context)
        {
            _context = context;
        }

        // GET: api/SnowBoards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SnowBoard>>> GetSnowBoardstb()
        {
            return await _context.SnowBoardstb.ToListAsync();
        }

        // GET: api/SnowBoards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SnowBoard>> GetSnowBoard(int id)
        {
            var snowBoard = await _context.SnowBoardstb.FindAsync(id);

            if (snowBoard == null)
            {
                return NotFound();
            }

            return snowBoard;
        }

        // PUT: api/SnowBoards/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSnowBoard(int id, SnowBoard snowBoard)
        {
            if (id != snowBoard.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(snowBoard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SnowBoardExists(id))
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

        // POST: api/SnowBoards
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SnowBoard>> PostSnowBoard(SnowBoard snowBoard)
        {
            _context.SnowBoardstb.Add(snowBoard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSnowBoard", new { id = snowBoard.OrderId }, snowBoard);
        }

        // DELETE: api/SnowBoards/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SnowBoard>> DeleteSnowBoard(int id)
        {
            var snowBoard = await _context.SnowBoardstb.FindAsync(id);
            if (snowBoard == null)
            {
                return NotFound();
            }

            _context.SnowBoardstb.Remove(snowBoard);
            await _context.SaveChangesAsync();

            return snowBoard;
        }

        private bool SnowBoardExists(int id)
        {
            return _context.SnowBoardstb.Any(e => e.OrderId == id);
        }
    }
}
