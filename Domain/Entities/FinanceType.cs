using Domain.Common;

namespace Domain.Entities
{
    public class FinanceType : BaseAuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
