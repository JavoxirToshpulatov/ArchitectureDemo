﻿using Demo.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApplication.Models
{
    public class CreatePersonModel
    {
        public int Code { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public Status Status { get; set; } = Status.active;
    }

    public class CreatePersonResponseModel
    {
        public int Id { get; set; }
    }
}