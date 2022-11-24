using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.Models
{
    internal class QcmQuestion : Question
    {
        private Dictionary<string, bool> reponses = new Dictionary<string, bool>();

        public QcmQuestion(string question, int note) : base(question, note)
        {
                                   
        }

        public void addReponse(String reponse, bool isCorrect)
        {
            reponses.Add(reponse, isCorrect);
        }

        public List<String> getAnswers()
        {
            List<String> answers = new List<String>();
            foreach (var answer in reponses)    
            {
                answers.Add(answer.Key);
            }
            return answers;
        }
    }
}

