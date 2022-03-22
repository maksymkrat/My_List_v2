using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace My_List_v2.Models.DeserializeTranslation
{
    [Serializable]
    public class Translater
    {
        [JsonPropertyName("source")]
        public Source Source { get; set; }
        
        [JsonPropertyName("target")]
        public Target Target { get; set; }
        
       
    }
}