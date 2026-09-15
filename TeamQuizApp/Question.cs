using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamQuizApp
{
    public class Question
    {
        public string Text { get; set; } = "";
        public string[] Choices { get; set; } = new string[4];
        public int CorrectIndex { get; set; }
    }

}
