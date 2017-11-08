using DAL.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IntAppTech.ViewModels
{
    public class QuestionViewModel
    {
        public int questionID { get; set; } 
        public string questionContent { get; set; }
        public int questionDegree { get; set; }

        // public int questionAuthorID { get; set; }
        // public int questionAuthor { get; set; }

        private ICollection<QuestionOptionViewModel> questionOptions { get; set; }
   
    }
}