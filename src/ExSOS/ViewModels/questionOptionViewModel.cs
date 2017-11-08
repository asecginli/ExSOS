using DAL.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IntAppTech.ViewModels
{
    public class QuestionOptionViewModel
    {
        public int questionOptionID { get; set; } 

        // [Required(), StringLength(4000), MaxLength(400)]
        public string optionContent { get; set; }
        [DefaultValue("false")]
        public bool isTrue { get; set; }

        
    }
}