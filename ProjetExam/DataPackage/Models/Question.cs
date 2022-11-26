using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.Models
{
    internal class Question
    {
        public String question { get; set; }
        public int note { get; set; }

        
        public String type { get; set; }
        public int id { get; set; }

        public Question(string question, int note)
        {
            this.question = question;
            this.note = note;
        }

        public Question(int id, string question, int note)
        {
            this.id = id;
            this.question = question;
            this.note = note;
        }

    }
}
