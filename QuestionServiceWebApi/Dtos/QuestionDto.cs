using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionServiceWebApi.Dtos
{
    public class QuestionDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<OptionDto> Options { get; set; } = new List<OptionDto>();
    }
}