using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Speech.Synthesis;
using System.Text.Json;
using System.Threading.Tasks;
using My_List_v2.Models;
using My_List_v2.Models.DeserializeTranslation;
using My_List_v2.Repository;


namespace My_List_v2.Business
{
    public class BusinessLogicImp : IBusinessLogic
    {
        private readonly SpeechSynthesizer _synthesizer;
        private readonly IWordRepository _wordRepository;
        

        private const string URL = "https://dev-api.itranslate.com/translation/v2/";
        private const string METHOD_POST = "POST";
        private const string HEADERS = "Bearer 603160b7-cee1-4c13-bcd7-37420b55211d";
        private const string CONTENT_TYPE = "application/json";

        public BusinessLogicImp(IWordRepository wordRepository)
        {
            _wordRepository = wordRepository;
            _synthesizer = new SpeechSynthesizer();
            _synthesizer.SetOutputToDefaultAudioDevice();
        }


        public Translater Translate(string word)
        {
            var httpRequest = (HttpWebRequest) WebRequest.Create(URL);
            httpRequest.Method = METHOD_POST;
            httpRequest.Headers["Authorization"] = HEADERS;
            httpRequest.ContentType = CONTENT_TYPE;

            var data = $@"{{
                         ""source"": {{""dialect"": ""en"", ""text"": ""{word}""}},
                         ""target"": {{""dialect"": ""uk""}}
                            }}";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            var httpResponse = (HttpWebResponse) httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                Translater translater = JsonSerializer.Deserialize<Translater>(result);
              
                return translater;
            }
            // Console.WriteLine(httpResponse.StatusCode);
           
        }
        
        
        public async Task Speech(string text)
        {
            _synthesizer.Speak(text);
        }

        public List<Word> GetFourWordsForTestWords()
        {
            return _wordRepository.GetFourWordsForTestWords();
        }

        public Word GetRandomWord()
        {
            return _wordRepository.GetRandomWord();
        }
    }
}