using Newtonsoft.Json;

namespace HackeruLecturers.Models
{
    public class Language
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
