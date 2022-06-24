using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Components;
using My_List_v2.Business;
using My_List_v2.Models;

namespace My_List_v2.Pages
{
    public class Compose_words_razor : ComponentBase
    {
        [Inject] private IBusinessLogic _business { get; set; }
        protected string ResultStyle { get; set; }
        protected Random random = new Random();
        protected Word MainWord{ get; set; }
        protected List<char> resultWord = new List<char>();
        protected List<char> mixedСharacters = new List<char>();
    
        
    
    
        protected override void OnInitialized()
        {
            MainWord = _business.GetRandomWord();
            char[] arrayChars = MainWord.WordText.ToCharArray();
            mixedСharacters = arrayChars.OrderBy(x => random.Next()).ToList();
            resultWord.Clear();
            ResultStyle = "light";
        }
    
        protected void ResetWord()
        {
           OnInitialized();
        }
    
        protected void AddCharForResult(char selectChar)
        {
            resultWord.Add(selectChar);
            mixedСharacters.Remove(selectChar);
            ResultStyle = "light";
            if (mixedСharacters?.Count == 0)
            {
                CompareWords();
                InvokeAsync(StateHasChanged);
            }
        }
    
        protected void DeleteCharWithResult(char selectChar)
        {
            resultWord.Remove(selectChar);
            mixedСharacters.Add(selectChar);
            ResultStyle = "light";
           
        }
    
        protected void CompareWords()
        {
            StringBuilder blindWord = new StringBuilder();
           
                for (int i = 0; i < resultWord.Count; i++)
            {
                blindWord.Append(resultWord[i]);
            }
            if (blindWord.ToString().Equals(MainWord.WordText))
            {
                ResultStyle = "success";
            }else
            {
                ResultStyle = "danger";
            }
        }
    }
}