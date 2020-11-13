using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using Moq.Protected;
using Twotter.Models;

namespace TestProject1
{

    public class ApiTest
    {

        [Test]
        public async Task GetPostFromApiTest()
        {
            var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent("{'Text':'This is a post'}"),
                })
                .Verifiable();

            var httpClient = new HttpClient(handlerMock.Object)
            {
                BaseAddress = new Uri("http://test.com/"),
            };

            var unit =  new PostApi(httpClient);
            var postCollection = await unit.GetPostAsync();
            Assert.AreEqual(typeof(Post), postCollection.GetType());
        }

    }
} 