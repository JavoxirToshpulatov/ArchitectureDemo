using Demo.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Models.PersonModels
{
    public class UpdatePersonModel
    {
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public Status Status { get; set; } = Status.active;
    }

    public class UpdatePersonResponseModel
    {
        public int Id { get; set; }
    }
}
