using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.Models
{
    internal class Question
    {
        public int id { get; set; }
        public String question { get; set; }
        public int note { get; set; }
        
        public String type { get; set; }

        public Question(string question, int note)
        {
            this.question = question;
            this.note = note;
            this.type = "ouverte";
        }

        public Question(int id, string question, int note)
        {
            this.id = id;
            this.question = question;
            this.note = note;
            this.type = "ouverte";
        }

    }
}
