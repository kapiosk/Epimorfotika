using System.Text.Json.Serialization;

namespace Epimorfotika
{
    internal class Row
    {
        public string ΕΠΑΡΧΙΑ { get; init; } = string.Empty;
        public string ΘΕΜΑ { get; init; } = string.Empty;
        public string ΕΠΙΠΕΔΟ { get; init; } = string.Empty;
        [JsonPropertyName("ΚΕΝΤΡΟ ΕΠΙΜΟΡΦΩΣΗΣ")]
        public string ΚΕΝΤΡΟΕΠΙΜΟΡΦΩΣΗΣ { get; init; } = string.Empty;
        [JsonPropertyName("ΩΡΑ ΔΙΕΞΑΓΩΓΗΣ")]
        public string ΩΡΑΔΙΕΞΑΓΩΓΗΣ { get; init; } = string.Empty;
        [JsonPropertyName("ΗΜΕΡΑ ΔΙΕΞΑΓΩΓΗΣ")]
        public string ΗΜΕΡΑΔΙΕΞΑΓΩΓΗΣ { get; init; } = string.Empty;
    }
}