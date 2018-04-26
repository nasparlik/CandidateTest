using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace QuestionServiceWebApi.Dtos
{
    public class QuestionnaireDto
    {
        [DataMember]
        public string QuestionnaireTitle { get; set; }
        [DataMember]
        public IList<QuestionDto> Questions { get; set; }
    }
}