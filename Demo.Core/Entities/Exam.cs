﻿namespace Demo.Core.Entities
{
    public class Exam : BaseEntity, IAuditEntity
    {
        public Class Class { get; set; }
        public int ClassId { get; set; }
        public Room Room { get; set; }
        public int RoomId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}