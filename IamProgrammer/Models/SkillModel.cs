using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IamProgrammer.Models
{
    [Table("Skill")]
    public class SkillModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<supporterModel> supporter { get; set; }

    }
}