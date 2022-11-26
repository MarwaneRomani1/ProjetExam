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
        private static List<Question> questions = new List<Question>();
        private static int selectedQuestion;

        private QuestionsDataSource() { }

        public static List<Question> getQuestionsList()
        {
            return questions;
        }

        public static Question getSelectedExam()
        {
            return questions[selectedQuestion];
        }

        public static void setSelectedExam(int index)
        {
            selectedQuestion = index;
        }

        public static void addExam(Question question)
        {
            questions.Add(question);
        }

        public void clearDataSource()
        {
            questions.Clear();
            selectedQuestion = -1;
        }
    }
}
