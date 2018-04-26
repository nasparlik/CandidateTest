using System.Collections.Generic;
using System.Linq;
using QuestionServiceWebApi.Interfaces;
using QuestionServiceWebApi.Models;

namespace QuestionServiceWebApi
{
    public class QuestionRepository : IQuestionRepository
    {
        private Questionnaire questionnaire = new Questionnaire
        {
            QuestionnaireTitle = "Geography Questions",
            Questions = new List<Question>{
               new Question{
                   Id =1,
                   Text = "What is the capital of Cuba?",
                   Options = new List<Option>{
                       new Option { Id = 1, Text = "Miami", IsCorrect = false },
                       new Option { Id = 2, Text = "Amsterdam", IsCorrect = false },
                       new Option { Id = 3, Text = "Cancun", IsCorrect = false },
                       new Option { Id = 4, Text = "Havana", IsCorrect = true}
                   }
               },
               new Question{
                   Id =2,
                   Text = "What is the capital of France?",
                   Options = new List<Option>{
                       new Option { Id = 1, Text = "London", IsCorrect = false },
                       new Option { Id = 2, Text = "Paris", IsCorrect = true },
                       new Option { Id = 3, Text = "Madrid", IsCorrect = false },
                       new Option { Id = 4, Text = "Rome", IsCorrect = false}
                   }
               },

               new Question{
                   Id =3,
                   Text = "What is the capital of Poland?",
                   Options = new List<Option>{
                       new Option { Id = 1, Text = "Warsaw", IsCorrect = true },
                       new Option { Id = 2, Text = "Vienna", IsCorrect = false },
                       new Option { Id = 3, Text = "Prague", IsCorrect = false },
                       new Option { Id = 4, Text = "Kiev", IsCorrect = false}
                   }
               },
               new Question{
                   Id =4,
                   Text = "What is the capital of Germany?",
                   Options = new List<Option>{
                       new Option { Id = 1, Text = "Brussels", IsCorrect = false },
                       new Option { Id = 2, Text = "Hamburg", IsCorrect = false },
                       new Option { Id = 3, Text = "Berlin", IsCorrect = true },
                       new Option { Id = 4, Text = "Oslo", IsCorrect = false}
                   }
               }
           }
        };

        public Questionnaire GetQuestionnaire()
        {
            return questionnaire;
        }

        public Question GetQuestionById(int id)
        {
            return questionnaire.Questions.FirstOrDefault(q => q.Id == id);
        }

        public IEnumerable<Question> GetQuestions()
        {
            return questionnaire.Questions.ToList();
        }
    }
}