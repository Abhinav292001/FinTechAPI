using FinTechAPI.Domain.Entities;

namespace FinTechAPI.Application.Interfaces
{
    public interface ITransactionRepository
    {
        /// <summary>
        /// This method helps to get the list of Transactions.
        /// </summary>
        /// <returns>List of Transactions</returns>
        Task<List<Transaction>> GetTransactionsAsync();
        /// <summary>
        /// This method helps to add a new transaction.
        /// </summary>
        /// <param name="transaction">transaction</param>
        /// <returns>Transaction</returns>
        Task<Transaction> AddTransactionAsync(Transaction transaction);
    }
}
