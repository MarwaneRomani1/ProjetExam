using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.DataAccessObject;
using ProjetExam.DataPackage.DatabaseConnection;
using ProjetExam.DataPackage.Models;
using ProjetExam.DataSource;
using System.Collections.Generic;

namespace ProjetExam.Forms
{
    public partial class QuestionManager : Form
    {
 
        private SqlConnection connection = SQLServerConnection.connect(@"Data Source=DESKTOP-83J8IV6;Initial Catalog=Exam;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        private String state;


        //data source for all questions and exam questions
        private QuestionsDataSource allQuestionsDS = new QuestionsDataSource();
        private QuestionsDataSource examQuestionsDS = new QuestionsDataSource();

        //fetch data in those lists
        private List<Question> questionsList;
        private List<Question> exQuestionsList;

        public QuestionManager()
        {
            InitializeComponent();
        }

        public QuestionManager(String state)
        {
            InitializeComponent();
            this.state = state;
        }


        private void QuestionManager_Load(object sender, EventArgs e)
        {
            button1_modifier_question.Visible = button2_modifier_question.Visible = false;
            button_delete_question.Visible = false;
            button_retirer_question.Visible = false;
            button_ajoute_question_exam.Enabled = false;


            //Data access objects for questions questions:
            QuestionDAO questionDAO = new QuestionDAO(connection);
            ExQuestionsDAO exQuestionsDAO = new ExQuestionsDAO(connection, ExamDataSource.getSelectedExam().id);

        
            if (this.state == "exam questions")
            {       
                exQuestionsList = exQuestionsDAO.getAll();
                renderUI(exQuestionsList, comboBox3);
                // fetch other questions (not in the exam)
                questionsList = questionDAO.getAllQuestionsNotInserted(ExamDataSource.getSelectedExam().id);

                foreach (Question question in exQuestionsList)
                {
                    examQuestionsDS.addQuestion(question);
                }
            } 
            else
            {   panel_exam_container.Visible = false;

                // fetch all questions
                questionsList = questionDAO.getAll();
            }

            foreach (Question question in questionsList)
            {
                allQuestionsDS.addQuestion(question);
            }
            renderUI(questionsList, comboBox2);
        }


        private void renderUI(List<Question> questions, ComboBox comboBox)
        {
            foreach (Question question in questions)
            {
                comboBox.Items.Add(question.question);
            }
        }

        private void modifier_question(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_modifier_question.Visible = true;
            button_ajoute_question_exam.Enabled = true;
            button_delete_question.Visible = true;

            allQuestionsDS.setSelectedQuestion(comboBox2.SelectedIndex);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2_modifier_question.Visible = true;
            examQuestionsDS.setSelectedQuestion(comboBox3.SelectedIndex);
            button_retirer_question.Visible = true;
        }

        private void button_ajoute_question_exam_Click(object sender, EventArgs e)
        {
            ExQuestionsDAO dao = new ExQuestionsDAO(connection, ExamDataSource.getSelectedExam().id);
            Question question = allQuestionsDS.getSelectedQuestion();

            int result = dao.save(question);

            if (result > 0)
            {
                SuccessForm success = new SuccessForm();
                success.ShowDialog();  
                comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
                comboBox3.Items.Add(question.question);
            }
        }

        private void button_nouvelle_question_Click(object sender, EventArgs e)
        {
            QuestionForm question = new QuestionForm(this);
            question.ShowDialog();
            
        }
        
        public void reload()
        {
            comboBox2.Items.Clear();
            QuestionDAO questionDAO = new QuestionDAO(connection);

            if (this.state == "exam")
                questionsList = questionDAO.getAllQuestionsNotInserted(ExamDataSource.getSelectedExam().id);
            else
                questionsList = questionDAO.getAll();

            renderUI(questionsList, comboBox2);
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
