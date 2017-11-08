

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DAL.Core;

namespace DAL.Models
{
    [Table("QuestionsTB")]
    public class Question : AuditableEntity
    {
        [Key]
        public int questionID { get; set; } 
        [StringLength(4000)]
        public string questionContent { get; set; }
        public questionDifficulty questionDegree { get; set; }
        
        [DefaultValue("true")]
        public bool isActive { get; set; } // soru onay asamasinda ya da gecici olarak kullanimdan kaldirilabilinir.

        /* soru yazarinin bilinmesi gerekir */
        public string questionAuthorID { get; set; }
        public ApplicationUser questionAuthor { get; set; }
        
        /* Bir soru sinirsiz sayida secenek / cevap icerebilir] */
        private ICollection<QuestionOption> questionOptions { get; set; }
        public ICollection<QuestionCategory> questionCategory { get; set; }

        /* bbirden fazla soru tek bir grup olarak kullnilabilir. Orn. Asagidaki x, y, z sorularini bu soruya gore cevaplayin.  */
        public int parentQuestionID { get; set; }
        public Question question { get; set; }

    }
}