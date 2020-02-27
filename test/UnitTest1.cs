using NUnit.Framework;
using System.Net.Http;
using System;
using System.Threading.Tasks;

namespace Testing_ColourAPI
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public async Task Test1()
        {
            var apiClient = new HttpClient();

            var apiResponse = await apiClient.GetAsync("http://colour_api:80/api/values");

            apiResponse.EnsureSuccessStatusCode();

            var responseString = await apiResponse.Content.ReadAsStringAsync();

            // Assert
            Assert.AreEqual("[{\"id\":1,\"colourName\":\"Red\"},{\"id\":2,\"colourName\":\"Orange\"},{\"id\":3,\"colourName\":\"Yellow\"},{\"id\":4,\"colourName\":\"Green\"},{\"id\":5,\"colourName\":\"Blue\"}]",
                responseString);
        }
    }
}