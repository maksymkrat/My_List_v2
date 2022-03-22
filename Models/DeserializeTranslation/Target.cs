using System.Text.Json.Serialization;

namespace My_List_v2.Models.DeserializeTranslation
{
    public class Target
    {
        [JsonPropertyName("dialect")]
        public string Dialect { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}