using AutoMapper;
using QuestionServiceWebApi.Dtos;
using QuestionServiceWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuestionServiceWebApi.App_Start
{
    public class MappingProfile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Questionnaire, QuestionnaireDto>();
            Mapper.CreateMap<Question, QuestionDto>();
            Mapper.CreateMap<Option, OptionDto>();
        }
    }
}