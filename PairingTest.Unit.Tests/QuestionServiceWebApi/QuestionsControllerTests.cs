using AutoMapper;
using Moq;
using NUnit.Framework;
using QuestionServiceWebApi;
using QuestionServiceWebApi.App_Start;
using QuestionServiceWebApi.Controllers;
using QuestionServiceWebApi.Dtos;
using QuestionServiceWebApi.Interfaces;

namespace PairingTest.Unit.Tests.QuestionServiceWebApi
{
    [TestFixture]
    public class QuestionsControllerTests
    {
        private Mock<IQuestionRepository> _repository;
        private QuestionsController _controller;
    

        [SetUp]
        public void SetUp()
        {
            _repository = new Mock<IQuestionRepository>();
            _controller = new QuestionsController(_repository.Object);
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
        }

        [Test]
        public void Get_WhenCalled_ShouldReturnExpectedQuestionnaire()
        {
            //Arrange
            var questionnaire = new Questionnaire();
           
            _repository.Setup(q => q.GetQuestionnaire()).Returns(questionnaire);

            //Act
            var result = _controller.Get();

            //Assert
            Assert.That(result, Is.TypeOf<QuestionnaireDto>());
        }

        [Test]
        public void Get_WhenCalled_ShouldReturnExpectedTitle()
        {
            //Arrange
            var expectedTitle = "My expected questions";
            _repository.Setup(q => q.GetQuestionnaire()).Returns(
                new Questionnaire { QuestionnaireTitle = expectedTitle });

            //Act
            var result = _controller.Get().QuestionnaireTitle;

            //Assert
            Assert.AreEqual(result,expectedTitle);
        }
    }
}