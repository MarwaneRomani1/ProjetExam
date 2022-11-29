using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.Models
{
    internal class QcmQuestion : Question
    {
        public int id_qcm { get; set; }
        public Dictionary<string, bool> choix = new Dictionary<string, bool>();

        public QcmQuestion(string question, int note) : base(question, note) {
            base.type = "qcm";
        }
    
        
        public void addChoix(String key, bool value)
        {
            choix.Add(key, value);
        }
    }
}

