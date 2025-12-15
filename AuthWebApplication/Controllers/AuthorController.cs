using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthWebApplication.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace AuthWebApplication.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  //[EnableCors]
  public class AuthorController : ControllerBase
  {
    private readonly ExamDb _context;

    public AuthorController(ExamDb context)
    {
      _context = context;
    }

    // GET: api/Author
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Author>>> GetAuthors()
    {
      return await _context.Authors.Include(a=> a.Books).ToListAsync();
    }

    // GET: api/Author/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Author>> GetAuthor(int id)
    {
      var author = await _context.Authors.FindAsync(id);

      if (author == null)
      {
        return NotFound();
      }
      await _context.Entry(author).Collection(a => a.Books).LoadAsync();
      return author;
    }

    // PUT: api/Author/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    //[Authorize]
    public async Task<IActionResult> PutAuthor(int id, Author author)
    {

      if (id != author.Id)
      {
        return BadRequest();
      }

      var old = await _context.Authors.Include(c => c.Books).FirstAsync(c => c.Id == id);

      if (old is not null)
      {
        _context.Authors.Remove(old);
      }

      await _context.Authors.AddAsync(author);
      //_context.Authors.Update(author);//.State = EntityState.Modified;
      
      try
      {
        await _context.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException ex)
      {
        if (!AuthorExists(id))
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

    // POST: api/Author
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
   // [Authorize]
    public async Task<ActionResult<Author>> PostAuthor(Author author)
    {
      try
      {
        _context.Authors.Add(author);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetAuthor", new { id = author.Id }, author);
      }
      catch (Exception ex)
      {
        return BadRequest(ex);
      }
     
    }

    // DELETE: api/Author/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAuthor(int id)
    {
      var author = await _context.Authors.FindAsync(id);
      if (author == null)
      {
        return NotFound();
      }

      _context.Authors.Remove(author);
      await _context.SaveChangesAsync();

      return NoContent();
    }

    private bool AuthorExists(int id)
    {
      return _context.Authors.Any(e => e.Id == id);
    }
  }
}
