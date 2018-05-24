using Newtonsoft.Json;

namespace VueWithTypescript.Models.Sample
{
    public class PostTestData
    {
        public PostTestData(string testText)
        {
            TestText = testText;
        }

        [JsonProperty("testText")]
        public string TestText { get; }
    }
}
