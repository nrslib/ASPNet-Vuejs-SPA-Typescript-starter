using Newtonsoft.Json;

namespace VueWithTypescript.Models.Sample
{
    public class PostRequest
    {
        [JsonProperty("sendData")]
        public string SendData { get; private set; }
    }
}
