using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("QuestionCategoryTrees")]
    public class QuestionCategoryTree : AuditableEntity
    {
        [Key]
        public int questionCategoryTreeID { get; set; }
        [StringLength(400)]
        public string questionCategoryTreeName { get; set; }
        public int parentQuestionCategoryTreeID { get; set; }
        public QuestionCategoryTree questionCategoryTree { get; set;}
    }
}