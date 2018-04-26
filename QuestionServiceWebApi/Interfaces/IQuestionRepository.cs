using QuestionServiceWebApi.Models;
using System.Collections.Generic;

namespace QuestionServiceWebApi.Interfaces
{
    public interface IQuestionRepository
    {
        Questionnaire GetQuestionnaire();
        Question GetQuestionById(int id);
        IEnumerable<Question> GetQuestions();
    }
}