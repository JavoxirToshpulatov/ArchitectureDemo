namespace Demo.Application.Models.ExamModels
{
    public class CreateExamModel
    {
        public int ClassId  { get; set; }
        public int RoomId { get; set; }
    }
    public class CreateExamResponseModel: BaseResponseModel { }
}
