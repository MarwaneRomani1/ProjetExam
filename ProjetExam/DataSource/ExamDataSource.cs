using ProjetExam.DataPackage.Models;


namespace ProjetExam.DataSource
{
    internal class ExamDataSource
    {
        private static List<Exam> exams = new List<Exam>();
        private static int selectedExam;

        private ExamDataSource() { }

        public static List<Exam> getExamsList()
        {
            return exams;
        }

        public static Exam getSelectedExam()
        {
            return exams[selectedExam];
        }

        public static void setSelectedExam(int index)
        {
            selectedExam = index;
        }

        public static void addExam(Exam Exam)
        {
            exams.Add(Exam);
        }
    }
}
