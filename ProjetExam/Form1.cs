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
            ExamForm productForm = new ExamForm();
            productForm.ShowDialog();
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            ExamForm productForm = new ExamForm("modification");
            productForm.ShowDialog();
        }
    }
}