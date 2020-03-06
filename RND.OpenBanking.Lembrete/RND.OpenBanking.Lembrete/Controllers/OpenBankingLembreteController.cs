using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RND.OpenBanking.Lembrete.Data;
using RND.OpenBanking.Lembrete.Interfaces;
using RND.OpenBanking.Lembrete.Models;

namespace RND.OpenBanking.Lembrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenBankingLembreteController : Controller
    {
        private readonly Context _context;        

        public OpenBankingLembreteController(Context context )
        {
            _context = context;           
        }

        // GET: api/OpenBankingLembrete
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LembreteModel>>> GetLembretes()
        {
            return await _context.Lembretes.Include(a => a.Usuario).ToListAsync();
        }

        // GET: api/OpenBankingLembrete/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LembreteModel>> GetLembreteModel(int id)
        {
            var lembreteModel = await _context.Lembretes.FindAsync(id);

            if (lembreteModel == null)
            {
                return NotFound();
            }

            return lembreteModel;
        }

        // PUT: api/OpenBankingLembrete/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLembreteModel(int id, LembreteModel lembreteModel)
        {
            if (id != lembreteModel.LembreteId)
            {
                return BadRequest();
            }

            _context.Entry(lembreteModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LembreteModelExists(id))
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

        // POST: api/OpenBankingLembrete
        [HttpPost]
        public async Task<ActionResult<LembreteModel>> PostLembreteModel(LembreteModel lembreteModel)
        {
            _context.Lembretes.Add(lembreteModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLembreteModel", new { id = lembreteModel.LembreteId }, lembreteModel);
        }

        // DELETE: api/OpenBankingLembrete/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LembreteModel>> DeleteLembreteModel(int id)
        {
            var lembreteModel = await _context.Lembretes.FindAsync(id);
            if (lembreteModel == null)
            {
                return NotFound();
            }

            _context.Lembretes.Remove(lembreteModel);
            await _context.SaveChangesAsync();

            return lembreteModel;
        }

        private bool LembreteModelExists(int id)
        {
            return _context.Lembretes.Any(e => e.LembreteId == id);
        }
    }
}
