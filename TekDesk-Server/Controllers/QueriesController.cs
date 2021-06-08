using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TekDesk_Server.Data;
using TekDesk_Server.Models;

namespace TekDesk_Server.Controllers
{
    [EnableCors("TCAPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class QueriesController : ControllerBase
    {
        private readonly TekDesk_ServerContext _context;

        public QueriesController(TekDesk_ServerContext context)
        {
            _context = context;
        }

        // GET: api/Queries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Query>>> GetQuery()
        {
            return await _context.Query.ToListAsync();
        }

        // GET: api/Queries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Query>> GetQuery(int id)
        {
            var query = await _context.Query.FindAsync(id);

            if (query == null)
            {
                return NotFound();
            }

            return query;
        }

        // PUT: api/Queries/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuery(int id, Query query)
        {
            if (id != query.QueryID)
            {
                return BadRequest();
            }

            _context.Entry(query).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QueryExists(id))
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

        // POST: api/Queries
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Query>> PostQuery(Query query)
        {
            _context.Query.Add(query);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuery", new { id = query.QueryID }, query);
        }

        // DELETE: api/Queries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Query>> DeleteQuery(int id)
        {
            var query = await _context.Query.FindAsync(id);
            if (query == null)
            {
                return NotFound();
            }

            _context.Query.Remove(query);
            await _context.SaveChangesAsync();

            return query;
        }

        private bool QueryExists(int id)
        {
            return _context.Query.Any(e => e.QueryID == id);
        }
    }
}
