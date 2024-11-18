using Demo.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Models.PersonModels
{
    public class CreatePersonModel
    {
        
        public string Name { get; set; }
        public Status Status { get; set; } = Status.active;
    }

    public class CreatePersonResponseModel
    {
        public int Id { get; set; }
    }
}
