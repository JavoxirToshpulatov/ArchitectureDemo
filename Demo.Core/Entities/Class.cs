using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Entities
{
    public class Class : BaseEntity, IAuditEntity   // sinf 
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public string? CreatedBy { get ; set ; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
