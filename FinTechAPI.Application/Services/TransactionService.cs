using FinTechAPI.Application.Interfaces;
using FinTechAPI.Domain.Entities;

namespace FinTechAPI.Application.Services;

public class TransactionService
{
    #region Dependencies
    /// <summary>
    /// an instance of transaction repository.
    /// </summary>
    private readonly ITransactionRepository _repository;
    #endregion

    #region Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="repository">ITransactionRepository</param>
    public TransactionService(ITransactionRepository repository)
    {
        _repository = repository;
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// This method calls the implemenation of interface to get the List of Transactions.
    /// </summary>
    /// <returns>List of Transactions</returns>
    public async Task<List<Transaction>> GetTransactionsAsync()
    {
        return await _repository.GetTransactionsAsync();
    }

    /// <summary>
    /// This method calls the implemenation of interface to add new Trasaction.
    /// </summary>
    /// <param name="transaction">Transaction</param>
    /// <returns>Transaction</returns>
    public async Task<Transaction> AddTransactionAsync(Transaction transaction)
    {
        return await _repository.AddTransactionAsync(transaction);
    }
    #endregion
}
