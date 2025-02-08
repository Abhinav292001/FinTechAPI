
namespace FinTechAPI.Domain.Entities
{
    public  class Transaction
    {
        /// <summary>
        /// Transaction's ID.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// User's ID who made the transaction.
        /// </summary>
        public required string UserId { get; set; }
        /// <summary>
        /// Amount for deposit/Withdrawal.
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// Type of transaction (Deposit, Withdraw).
        /// </summary>
        public required string Type { get; set; }
        /// <summary>
        /// Transaction's created time.
        /// </summary>
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
