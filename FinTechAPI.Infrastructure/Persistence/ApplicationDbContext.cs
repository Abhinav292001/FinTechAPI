using FinTechAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinTechAPI.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext
{
    #region Constructor
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="options">DbContextOptions</param>
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    #endregion

    #region public members
    /// <summary>
    /// Transactions
    /// </summary>
    public DbSet<Transaction> Transactions { get; set; }
    #endregion
}
