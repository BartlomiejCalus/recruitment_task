using Newtonsoft.Json;

namespace myFunction.Entities.Output
{
    public class CustomExtraFields
    {
        [JsonProperty("135")]
        public string _135 { get; set; }

        [JsonProperty("172")]
        public string _172 { get; set; }
    }
}
