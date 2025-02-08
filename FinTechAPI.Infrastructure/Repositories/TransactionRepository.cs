using FinTechAPI.Application.Interfaces;
using FinTechAPI.Domain.Entities;
using FinTechAPI.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FinTechAPI.Infrastructure.Repositories;

public class TransactionRepository : ITransactionRepository
{
    #region Dependencies
    /// <summary>
    /// an instance of ApplicationDbContext
    /// </summary>
    private readonly ApplicationDbContext _context;
    #endregion

    #region Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="context">context</param>
    public TransactionRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// <see cref="ITransactionRepository.GetTransactionsAsync()"/>
    /// </summary>
    public async Task<List<Transaction>> GetTransactionsAsync()
    {
        return await _context.Transactions.ToListAsync();
    }
    /// <summary>
    /// <see cref="ITransactionRepository.AddTransactionAsync(Transaction)"/>
    /// </summary>
    public async Task<Transaction> AddTransactionAsync(Transaction transaction)
    {
        var newtransaction = new Transaction
        {
            UserId = transaction.UserId,
            Amount = transaction.Amount,
            Type = transaction.Type,
            CreatedAt = DateTime.UtcNow
        };
        _context.Transactions.Add(newtransaction);
        await _context.SaveChangesAsync();
        return transaction;
    }
    #endregion
}
