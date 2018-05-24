using Newtonsoft.Json;

namespace VueWithTypescript.Models.Sample
{
    public class GetTestData
    {
        public GetTestData(string testData)
        {
            TestData = testData;
        }

        [JsonProperty("testData")]
        public string TestData { get; }
    }
}
