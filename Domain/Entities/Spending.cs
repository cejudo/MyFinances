using Domain.Common;

namespace Domain.Entities
{
    public class Spending : BaseAuditableEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime SpendingDate { get; set; }
        public int FinanceTypeId { get; set; }

        public FinanceType FinanceType { get; set; }
    }
}
