using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IamProgrammer.Models
{
    [Table("supporter")]
    public class supporterModel
    {
        public int Id { get; set; }

        [Display(Name = "نام")]
        [MinLength(3, ErrorMessage = "حداقل سه کاراکتر الزامی است")]
        [MaxLength(10 , ErrorMessage = "حداکثر 10 کاراکتر مجاز می باشد")]
        [Required(ErrorMessage = "برای نمایش در حامیان نام لازم است")]
        public string Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "برای نمایش در حامیان نام خانوادگی لازم است")]
        [MinLength(3, ErrorMessage = "حداقل سه کاراکتر الزامی است")]
        [MaxLength(25, ErrorMessage = "حداکثر 25 کاراکتر مجاز می باشد")]
        public string Family { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "این فیلد الزامی است")]
        [EmailAddress(ErrorMessage = "ایمیل صحیح نمی باشد")]
        [Remote("IsUniqueEmail", "supporter" , ErrorMessage = "این ایمیل از قبل موجود است" ) ]
        public string Email { get; set; }

        [Display(Name = "شماره موبایل")]
        [RegularExpression(@"(^09[1|2|3][0-9]{8}$)|(^\u0660\u0669[\u0660-\u0669]{9}$)", ErrorMessage = "شماره موبایل وارد شده صحیح نمی باشد")]
        public string Phone { get; set; }

        [Display(Name = "مهارت")]
        [ForeignKey("skillId")]
        public virtual SkillModel Skill { get; set; }
        public int skillId { get; set; }

        [Display(Name = "جنسیت")]
        public bool Gender { get; set; }

        [Display(Name = "مشترک شوید")]
        public bool SubscribeEmail { get; set; }

        [Display(Name = "مشغول به کار")]
        public bool IsWorking { get; set; }

    }

}