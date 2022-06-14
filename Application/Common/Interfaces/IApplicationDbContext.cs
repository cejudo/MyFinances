using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Spending> Spendings { get; }
        DbSet<Income> Incomes { get; }
        DbSet<ActiveData> ActiveData { get; }
        DbSet<FinanceType> FinanceTypes { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
