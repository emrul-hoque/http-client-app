using System.Text.Json.Serialization;

namespace Demo.App.Models.WeatherApi
{
    public class Location
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;

        [JsonPropertyName("region")]
        public string Region { get; set; } = string.Empty;

        [JsonPropertyName("lat")]
        public string Lat { get; set; } = string.Empty;

        [JsonPropertyName("lon")]
        public string Lon { get; set; } = string.Empty;

        [JsonPropertyName("timezone_id")]
        public string TimezoneId { get; set; } = string.Empty;

        [JsonPropertyName("localtime")]
        public string LocalTime { get; set; } = string.Empty;

        [JsonPropertyName("localtime_epoch")]
        public int LocalTimeEpoch { get; set; }

        [JsonPropertyName("utc_offset")]
        public string UtcOffset { get; set; } = string.Empty;
    }
}