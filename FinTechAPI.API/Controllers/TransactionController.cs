using FinTechAPI.Application.Services;
using FinTechAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FinTechAPI.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    private readonly TransactionService _service;

    public TransactionController(TransactionService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetTransactions()
    {
        return Ok(await _service.GetTransactionsAsync());
    }

    [HttpPost]
    public async Task<IActionResult> AddTransaction([FromBody] Transaction transaction)
    {
        var newTransaction = await _service.AddTransactionAsync(transaction);
        return CreatedAtAction(nameof(GetTransactions), new { id = newTransaction.Id }, newTransaction);
    }
}
