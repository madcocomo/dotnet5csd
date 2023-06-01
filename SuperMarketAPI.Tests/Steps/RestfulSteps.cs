using TechTalk.SpecFlow;
using FluentAssertions;
using FluentAssertions.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SuperMarketAPI.Tests.Steps
{
    [Binding]
	public class RestfulSteps
	{
        private readonly CustomWebApplicationFactory<Program> factory;
        private HttpResponseMessage response;

        public RestfulSteps(CustomWebApplicationFactory<Program> factory)
        {
            this.factory = factory;
        }

        [When(@"I '(.*)' the api '(.*)'")]
        public async Task WhenICallTheApi(string method, string apiName)
        {
            var client = factory.CreateClient();
            response = await client.GetAsync($"/api{apiName}");
        }

        [Then(@"the server response will match$")]
        public void ThenTheServerResponseWillMatch(string expectedResponse)
        {
            response.IsSuccessStatusCode.Should().BeTrue();
            assertResponse(expectedResponse);
        }

        [Then(@"the server error response will match$")]
        public void ThenTheServerErrorResponseWillMatch(string expectedResponse)
        {
            response.IsSuccessStatusCode.Should().BeFalse();
            assertResponse(expectedResponse);
        }

        private void assertResponse(string expectedResponse)
        {
            var actual = response.Content.ReadAsStringAsync().Result;
            var expectedJson = toJson(expectedResponse);

            if (expectedJson == null)
            {
                actual.Should().BeEquivalentTo(expectedResponse);
            }
            else
            {
                toJson(actual).Should().ContainSubtree(expectedJson);
            }
        }

        private static JToken? toJson(string value)
        {
            try
            {
                return JToken.Parse(value);
            }
            catch
            {
                return null;
            }


        }

    }
}

