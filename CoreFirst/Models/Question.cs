using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFirst.Models
{
    public enum Answer:byte
    {
        A,
        B,
        C,
        D
    }
    public class Question
    {
      
        public int Id { get; set; }
        public string Title { get; set; }
        
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public Answer Answer { get; set; }



    }
}
