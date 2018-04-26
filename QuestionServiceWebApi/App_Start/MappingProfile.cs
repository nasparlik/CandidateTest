using AutoMapper;
using QuestionServiceWebApi.Dtos;
using QuestionServiceWebApi.Models;


namespace QuestionServiceWebApi.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Questionnaire, QuestionnaireDto>();
            Mapper.CreateMap<QuestionnaireDto, Questionnaire>();
            Mapper.CreateMap<Question, QuestionDto>();
            Mapper.CreateMap<Option, OptionDto>();
        }
    }
}