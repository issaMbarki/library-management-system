using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController(IBookService bookService) : ControllerBase
    {
        private readonly IBookService _bookService = bookService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetAll() =>
            Ok(await _bookService.GetAllAsync());

        [HttpPost]
        public async Task<ActionResult<BookDto>> Create([FromBody] CreateBookRequest request)
        {
            var created = await _bookService.CreateAsync(request);
            return CreatedAtAction(nameof(GetAll), new { id = created.Id }, created);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _bookService.DeleteAsync(id);
            return NoContent();
        }
    }
}
