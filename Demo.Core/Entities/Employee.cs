namespace Demo.Core.Entities
{
    public class Employee : BaseEntity, IAuditEntity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
