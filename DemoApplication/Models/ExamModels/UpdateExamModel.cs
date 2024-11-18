using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.Models.ExamModels
{
    public class UpdateExamModel
    {
        public int ClassId { get; set; }
        public int RoomId { get; set; }
    }
    public class UpdateExamResponseModel : BaseResponseModel { }
}
