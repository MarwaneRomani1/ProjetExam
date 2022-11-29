using ProjetExam.DataPackage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataSource
{
    internal class QuestionsDataSource
    {
        private List<Question> questions = new List<Question>();
        public int selectedQuestion { get; set; }

        public QuestionsDataSource() {
        
        }

        public List<Question> getQuestionsList()
        {
            return questions;
        }

        public Question getSelectedQuestion()
        {

            return questions[selectedQuestion];
        }

        public void setSelectedQuestion(int index)
        {
            selectedQuestion = index;
        }

        public void addQuestion(Question question)
        {
            questions.Add(question);
        }

        public void clearDataSource()
        {
            questions.Clear();
            selectedQuestion = 0;
        }

        public void remove(int index)
        {
            questions.RemoveAt(index);
        }
    }
}
