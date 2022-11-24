using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.Models
{
    internal class Question
    {
        protected String question { get; set; }
        protected int note { get; set; }

        public Question(string question, int note)
        {
            this.question = question;
            this.note = note;
        }

    }
}
