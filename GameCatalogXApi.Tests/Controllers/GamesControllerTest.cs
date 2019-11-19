using GameCatalogXApi.Controllers;
using GameCatalogXApi.Logic;
using GameCatalogXApi.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using System.Web.ModelBinding;

namespace GameCatalogXApi.Tests.Controllers
{
    [TestClass]
    public class GamesControllerTest
    {
        private GameDTO _gameDTO;

        public GamesControllerTest()
        {
            _gameDTO = new GameDTO()
            {
                Name = "Fake Name",
                Description = "Test Description",
                Developer = "Test Developer",
                Publisher = "Test Publisher",
                About = "Test of About",
                Price = 44.99m,
                CustomerReviews = new List<CustomerReviewDTO>()
                {
                    new CustomerReviewDTO()
                    {
                        Rating = 4,
                        Review = "Not so good",
                        UserName = "atb123"
                    }
                },
                Images = new List<ImageDTO>()
                {
                    new ImageDTO()
                    {
                        ImageUrl = "/img/image_file.jpg"
                    }
                },
                SystemRequirements = new List<SystemRequirementsDTO>()
                {
                    new SystemRequirementsDTO()
                    {
                        DirectX = 11,
                        Graphics = "Good Grahpics card",
                        Memory = 6,
                        OS = "Windows 7",
                        Processor = "AMD Wow processor",
                        Storage = 55
                    }
                }
            };
        }

        [TestMethod]
        public async Task Put_Should_Return_200_Valid_Request()
        {
            // Arrange
            Mock<IGameLogic> gameLogic = new Mock<IGameLogic>();
            GamesController gc = new GamesController(gameLogic.Object)
            {
                Request = new HttpRequestMessage()
                {
                    Content = new StringContent("", Encoding.UTF8, "application/json")
                }
            };

            // Act
            var response = await gc.Put(1, _gameDTO);
            
            // Assert
            Assert.IsTrue(response is System.Web.Http.Results.OkResult);
        }

        [TestMethod]
        public async Task Put_Should_Return_Bad_Request_With_Zero_Id()
        {
            // Arrange
            Mock<IGameLogic> gameLogic = new Mock<IGameLogic>();
            GamesController gc = new GamesController(gameLogic.Object)
            {
                Request = new HttpRequestMessage()
                {
                    Content = new StringContent("", Encoding.UTF8, "application/json")
                }
            };

            // Act
            var response = await gc.Put(0, _gameDTO);

            // Assert
            Assert.IsTrue(response is System.Web.Http.Results.BadRequestErrorMessageResult);
        }

        [TestMethod]
        public async Task Put_Should_Return_Unsupported_Media_Type_With_Wrong_Media_Type()
        {
            // Arrange
            Mock<IGameLogic> gameLogic = new Mock<IGameLogic>();
            GamesController gc = new GamesController(gameLogic.Object)
            {
                Request = new HttpRequestMessage()
                {
                    // wrong type
                    Content = new StringContent("", Encoding.UTF8, "application/xml")
                }
            };

            // Act
            var response = await gc.Put(1, _gameDTO) as System.Web.Http.Results.StatusCodeResult;
             
            // Assert
            Assert.AreEqual(HttpStatusCode.UnsupportedMediaType, response.StatusCode);
        }



    }
}
