using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reCAPTCHA_Backend.Models
{
    public class RecaptchaResponse
    {
        //[JsonProperty("success")]
        //public bool Success { get; set; }

        //[JsonProperty("error-codes")]
        //public List<string> ErrorMessages { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error-codes")]
        public IEnumerable<string> ErrorCodes { get; set; }

        [JsonProperty("challenge_ts")]
        public DateTime ChallengeTs { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }
    }
}
