using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IamProgrammer.Models
{
    [Table("Reports")]
    public class ReportModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "زمان گزارش گیری")]
        public DateTime Date { get; set; }
        [Display(Name = "تعداد حامی ها")]
        public int CountSupporter { get; set; }
        [Display(Name = "خانم")]
        public int Female { get; set; }
        [Display(Name = "آقا")]
        public int Male { get; set; }
        [Display(Name = "آماده برای استخدام")]
        public int ReadyForHire { get; set; }
        [Display(Name = "مشغول به کار")]
        public int IsWorking { get; set; }
        [NotMapped]
        [Display(Name = "مشغول به کار / درصدی")]
        public int IsWorkingPercent { get { return (IsWorking * 100) / CountSupporter; } }
        [NotMapped]
        [Display(Name = "آماده به استخدام / درصدی")]
        public int ReadyForHirePercent { get { return (ReadyForHire * 100) / CountSupporter; } }

        [Display(Name = "آقا / درصدی")]
        public int MalePercent { get { return (Male * 100) / CountSupporter; } }
        [Display(Name = "خانم / درصدی")]
        public int FemalPercent { get { return (Female * 100) / CountSupporter; } }

    }
}