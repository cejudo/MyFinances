using Domain.Common;

namespace Domain.Entities
{
    public class Income : BaseAuditableEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime IncomeDate { get; set; }
        public int FinanceTypeId { get; set; }

        public FinanceType FinanceType { get; set; }
    }
}
