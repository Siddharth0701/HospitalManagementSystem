using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewUserRegistersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NewUserRegistersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/NewUserRegisters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewUserRegister>>> GetNewUserRegister()
        {
            return await _context.NewUserRegister.ToListAsync();
        }

        // GET: api/NewUserRegisters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewUserRegister>> GetNewUserRegister(int id)
        {
            var newUserRegister = await _context.NewUserRegister.FindAsync(id);

            if (newUserRegister == null)
            {
                return NotFound();
            }

            return newUserRegister;
        }

        // PUT: api/NewUserRegisters/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewUserRegister(int id, NewUserRegister newUserRegister)
        {
            if (id != newUserRegister.Id)
            {
                return BadRequest();
            }

            _context.Entry(newUserRegister).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewUserRegisterExists(id))
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

        // POST: api/NewUserRegisters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NewUserRegister>> PostNewUserRegister(NewUserRegister newUserRegister)
        {
            _context.NewUserRegister.Add(newUserRegister);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNewUserRegister", new { id = newUserRegister.Id }, newUserRegister);
        }

        // DELETE: api/NewUserRegisters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NewUserRegister>> DeleteNewUserRegister(int id)
        {
            var newUserRegister = await _context.NewUserRegister.FindAsync(id);
            if (newUserRegister == null)
            {
                return NotFound();
            }

            _context.NewUserRegister.Remove(newUserRegister);
            await _context.SaveChangesAsync();

            return newUserRegister;
        }

        private bool NewUserRegisterExists(int id)
        {
            return _context.NewUserRegister.Any(e => e.Id == id);
        }
    }
}
