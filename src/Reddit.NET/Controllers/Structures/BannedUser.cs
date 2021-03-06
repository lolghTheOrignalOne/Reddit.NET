﻿using Newtonsoft.Json;
using Reddit.Models.Converters;
using System;

namespace Reddit.Controllers.Structures
{
    [Serializable]
    public class BannedUser
    {
        [JsonProperty("date")]
        [JsonConverter(typeof(UtcTimestampConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
