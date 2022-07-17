using Newtonsoft.Json;
using System.Collections.Generic;

namespace HackeruLecturers.Models
{
    public class Lecturer
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("languages")]
        public List<long> Languages { get; set; }
    }
}
