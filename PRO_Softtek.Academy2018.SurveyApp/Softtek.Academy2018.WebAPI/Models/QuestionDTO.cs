﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Softtek.Academy2018.WebAPI.Models
{
    public class QuestionDTO
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int QuestionTypeId { get; set; }
    }
}