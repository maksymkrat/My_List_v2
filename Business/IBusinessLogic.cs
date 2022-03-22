using System.Collections.Generic;
using System.Threading.Tasks;
using My_List_v2.Models;
using My_List_v2.Models.DeserializeTranslation;

namespace My_List_v2.Business
{
    public interface IBusinessLogic
    {
        Translater Translate(string word);
        
        Task Speech(string text);
        
        List<Word> GetFourWordsForTestWords();

        Word GetRandomWord();

    }
}