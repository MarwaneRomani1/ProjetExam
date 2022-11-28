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

        public QcmQuestion(string question, int note) : base(question, note) { }
    }
}

