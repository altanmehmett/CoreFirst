using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFirst.Models
{
    public class UserExamResult
    {
        public int Id { get; set; }
        public Question Question { get; set; }

        [Display(Name="Doğru cevap sayısı")]
        public int CorrectAnswersCount { get; set; }

        

    }
}
