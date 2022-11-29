using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.DataAccessObject;
using ProjetExam.DataPackage.DatabaseConnection;
using ProjetExam.DataPackage.Models;
using ProjetExam.DataSource;
using ProjetExam.Forms;

namespace ProjetExam
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = SQLServerConnection.connect(@"Data Source=DESKTOP-83J8IV6;Initial Catalog=Exam;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //disable button modify and delete
            button_modifier.Enabled = false;
            button_supprimer.Enabled = false;
            

            // fetch all exams from the DB
            ExamDAO examDAO = new ExamDAO(connection);
            List<Exam> result = examDAO.getAll();

            foreach (var exam in result)
            {
                comboBox1.Items.Add(exam.titre);
                ExamDataSource.addExam(exam);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_modifier.Enabled = true;
            button_supprimer.Enabled = true;
     
            ExamDataSource.setSelectedExam(comboBox1.SelectedIndex);

           }

        private void button_nouveau_Click(object sender, EventArgs e)
        {
            ExamForm productForm = new ExamForm(this);
            productForm.ShowDialog();
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm(this,"modification");
            examForm.ShowDialog();
        }

        private void button_manage_questions_Click(object sender, EventArgs e)
        {
            QuestionManager questionsForm;
            if (button_modifier.Enabled != false)
                questionsForm = new QuestionManager("exam questions");
            else
                questionsForm = new QuestionManager();
            
            questionsForm.ShowDialog();
        
            }

        public void reload()
        {
            ExamDataSource.clearList();
            comboBox1.Items.Clear();

            ExamDAO examDAO = new ExamDAO(connection);
            List<Exam> result = examDAO.getAll();

            foreach (var exam in result)
            {
                comboBox1.Items.Add(exam.titre);
                ExamDataSource.addExam(exam);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            ExamDAO examDAO = new ExamDAO(connection);
            ExQuestionsDAO exQuestionsDAO = new ExQuestionsDAO(connection,ExamDataSource.getSelectedExam().id);

            exQuestionsDAO.delete();

            int result = examDAO.delete(ExamDataSource.getSelectedExam());
            if (result > 0)
            {
                SuccessForm success = new SuccessForm();
                success.ShowDialog();
                this.reload();
            }
        }
    }
}
