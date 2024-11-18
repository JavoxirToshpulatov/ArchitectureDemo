using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Entities
{
    public class Student : BaseEntity, IAuditEntity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public Class Class { get; set; }
        public int ClassId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }
}
