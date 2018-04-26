using System.Collections.Generic;
using QuestionServiceWebApi;
using QuestionServiceWebApi.Interfaces;
using QuestionServiceWebApi.Models;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi.Stubs
{
    public class FakeQuestionRepository : IQuestionRepository
    {
        public Questionnaire ExpectedQuestions { get; set; }

        public Question GetQuestionById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Questionnaire GetQuestionnaire()
        {
            return ExpectedQuestions;
        }

        public IEnumerable<Question> GetQuestions()
        {
            throw new System.NotImplementedException();
        }
    }
}