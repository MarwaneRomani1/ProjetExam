using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.Models
{
    internal class Exam
    {
        public int id { get; set; }
        public string titre { get; set; }
        public string level { get; set; }
        public String date { get; set; }
        public int durre { get; set; }

        public List<Question> questions { get; }

        
        public Exam(String titre, string level, String date, int durre)
        {
            this.titre = titre;
            this.level = level;
            this.date = date;
            this.durre = durre;
        }

        public Exam(int id,String titre,string level, String date, int durre)
        {
            this.id = id;
            this.titre = titre;
            this.level = level;
            this.date = date;
            this.durre = durre;
        }
    }
}
