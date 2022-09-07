using System.Text.Json.Serialization;

namespace Epimorfotika
{
    internal class Data
    {
        [JsonPropertyName("total_rows")]
        public int Total_rows { get; init; }
        [JsonPropertyName("rows")]
        public Row[] Rows { get; init; } = Array.Empty<Row>();
        [JsonPropertyName("headers")]
        public string[] Headers { get; init; } = Array.Empty<string>();
    }
}