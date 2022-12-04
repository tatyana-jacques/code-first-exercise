﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodeFirstExerciseApi.Context;
using CodeFirstExerciseApi.Models;

namespace CodeFirstExerciseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrutorController : ControllerBase
    {
        private readonly CursoSenaiContext _context;

        public InstrutorController(CursoSenaiContext context)
        {
            _context = context;
        }

        // GET: api/Instrutor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instrutor>>> GetInstrutores()
        {
            return await _context.Instrutores.ToListAsync();
        }

        // GET: api/Instrutor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instrutor>> GetInstrutor(int id)
        {
            var instrutor = await _context.Instrutores.FindAsync(id);

            if (instrutor == null)
            {
                return NotFound();
            }

            return instrutor;
        }

        // PUT: api/Instrutor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstrutor(int id, Instrutor instrutor)
        {
            if (id != instrutor.Id)
            {
                return BadRequest();
            }

            _context.Entry(instrutor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstrutorExists(id))
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

        // POST: api/Instrutor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Instrutor>> PostInstrutor(Instrutor instrutor)
        {
            _context.Instrutores.Add(instrutor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstrutor", new { id = instrutor.Id }, instrutor);
        }

        // DELETE: api/Instrutor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstrutor(int id)
        {
            var instrutor = await _context.Instrutores.FindAsync(id);
            if (instrutor == null)
            {
                return NotFound();
            }

            _context.Instrutores.Remove(instrutor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InstrutorExists(int id)
        {
            return _context.Instrutores.Any(e => e.Id == id);
        }
    }
}
