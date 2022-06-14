using Domain.Common;

namespace Domain.Entities
{
    public class ActiveData : BaseAuditableEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime ActiveDataDate { get; set; }
        public bool IsActive { get; set; }
        public int FinanceTypeId { get; set; }

        public FinanceType FinanceType { get; set; }
    }
}
