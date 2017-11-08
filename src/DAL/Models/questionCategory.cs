using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("QuestionCategories")]
    public class QuestionCategory : AuditableEntity
    {
        [Key]
        public int questionCategoryID { get; set; }
        public int parentQuestionCategoryID { get; set; }
        public QuestionCategory parentQuestionCategory { get; set;}

        public int questionCategoryTreeID { get; set; }
        public QuestionCategoryTree questionCategoryTree { get; set;}

        public int questionID { get; set; }
        public Question question { get; set; }
    }
}