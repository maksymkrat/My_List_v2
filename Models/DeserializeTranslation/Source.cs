using System.Text.Json.Serialization;

namespace My_List_v2.Models.DeserializeTranslation
{
    public class Source
    {
        [JsonPropertyName("dialect")]
        public string Dialect { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}