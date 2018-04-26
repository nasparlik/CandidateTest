using System.Web.Http;
using AutoMapper;
using QuestionServiceWebApi.Dtos;
using QuestionServiceWebApi.Interfaces;

namespace QuestionServiceWebApi.Controllers
{
    public class QuestionsController : ApiController
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionsController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public QuestionsController() : this(new QuestionRepository()) {}

        // GET api/questions
        public QuestionnaireDto Get()
        {
            var qustionnaire = _questionRepository.GetQuestionnaire();

            return Mapper.Map<Questionnaire, QuestionnaireDto>(qustionnaire);
        }

        // GET api/questions/5
        public string Get(int id)
        {
            return "";
        }

        // POST api/questions
        public void Post([FromBody]string value)
        {
        }

        // PUT api/questions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/questions/5
        public void Delete(int id)
        {
        }
    }
}
