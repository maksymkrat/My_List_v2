using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using My_List_v2.Models;

namespace My_List_v2.Repository
{
    public interface IWordRepository
    {
        Task<List<Word>> GetAllWords();
        Task<bool> AddWord( Word word);
      
        Task<bool> DeleteWordById(int id);
        List<Word> GetFourWordsForTestWords();
        void UpdateWord(Word word);

        Word GetRandomWord();






    }
}