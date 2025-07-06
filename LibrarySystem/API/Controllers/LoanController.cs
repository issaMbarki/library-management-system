using LibrarySystem.Application.DTOs;
using LibrarySystem.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController(ILoanService loanService) : ControllerBase
    {
        private readonly ILoanService _loanService = loanService;
        [HttpPost("borrow")]
        public async Task<IActionResult> BorrowBook([FromBody] BorrowBookRequest request)
        {
            await _loanService.BorrowBookAsync(request);
            return Ok("Book borrowed.");
        }
    }
}