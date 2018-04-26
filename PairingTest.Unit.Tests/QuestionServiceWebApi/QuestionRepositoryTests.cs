using NUnit.Framework;
using QuestionServiceWebApi;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    [TestFixture]
    public class QuestionRepositoryTests
    {
        [Test]
        public void GetQuestionnaire_WhenCalled_ShouldReturnExpectedQuestionnaire()
        {
            var questionRepository = new QuestionRepository();

            var questionnaire = questionRepository.GetQuestionnaire();

            Assert.That(questionnaire.QuestionnaireTitle, Is.EqualTo("Geography Questions"));
            Assert.That(questionnaire.Questions[0].Text, Is.EqualTo("What is the capital of Cuba?"));
            Assert.That(questionnaire.Questions[1].Text, Is.EqualTo("What is the capital of France?"));
            Assert.That(questionnaire.Questions[2].Text, Is.EqualTo("What is the capital of Poland?"));
            Assert.That(questionnaire.Questions[3].Text, Is.EqualTo("What is the capital of Germany?"));
        }

       [Test]
        public void GetQuestionById_WhenCalled_ShouldReturnExpectedQuestion()
        {
            var questionRepository = new QuestionRepository();

            var result = questionRepository.GetQuestionById(1).Text;

            Assert.That(result, Is.EqualTo("What is the capital of Cuba?"));
        }

    }
}