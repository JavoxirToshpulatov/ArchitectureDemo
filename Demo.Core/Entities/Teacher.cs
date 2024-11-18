namespace Demo.Core.Entities
{
    public class Teacher : BaseEntity, IAuditEntity
    {
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
