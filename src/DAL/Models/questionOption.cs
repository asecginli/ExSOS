using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    [Table("QuestionOptionsTB")]
    public class QuestionOption : AuditableEntity
    {
        [Key]
        public int questionOptionID { get; set; } 
        [Required]

        public string optionContent { get; set; }
        [DefaultValue("false")]
        public bool isTrue { get; set; }

        public int questionID { get; set; }
        public Question question { get; set; }
    }
}