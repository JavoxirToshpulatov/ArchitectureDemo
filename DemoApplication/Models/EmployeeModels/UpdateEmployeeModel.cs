using Demo.Core.Enum;

namespace Demo.Application.Models.EmployeeModels
{
    public class UpdateEmployeeModel
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; } = Status.active;
    }
    public class UpdateEmployeeResponseModel : BaseResponseModel { }
}
