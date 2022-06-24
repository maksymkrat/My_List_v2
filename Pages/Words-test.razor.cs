using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;
using My_List_v2.Business;
using My_List_v2.Models;

namespace My_List_v2.Pages
{
    public class Words_test_razor : ComponentBase
    {
        [Inject]  IBusinessLogic _business{ get; set; }
        protected Word MainWord { get; set; }
        protected List<Word> Words{ get; set; }
        protected Random rnd = new Random();
        protected string resultStyle = "light";
        protected string mainWordStyle = "light";
        protected int rndWord = 0;
    
    
        protected override void OnInitialized()
        {
         
            Words = _business.GetFourWordsForTestWords();
            MainWord = Words.ElementAt(rnd.Next(0, Words.Count));
        }
    

        protected void ChangeStyleMainWord(string style)
        {
            mainWordStyle = style;
        
        }

        protected void ResetWord()
        {
            Words = _business.GetFourWordsForTestWords();
            MainWord = Words.ElementAt(rnd.Next(0, Words.Count));
            resultStyle = "light";
            mainWordStyle = resultStyle;
        }


    }
}