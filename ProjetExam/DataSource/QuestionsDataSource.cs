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
        private int selectedQuestion;

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
            selectedQuestion = -1;
        }

        internal void remove(int index)
        {
            questions.RemoveAt(index);
        }
    }
}
