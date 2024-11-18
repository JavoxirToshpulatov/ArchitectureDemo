using Demo.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public Status Status  { get; set; } = Status.active;
    }
}
