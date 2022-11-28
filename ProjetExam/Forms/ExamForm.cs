using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.DataAccessObject;
using ProjetExam.DataPackage.DatabaseConnection;
using ProjetExam.DataPackage.Models;
using ProjetExam.DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetExam.Forms
{
    public partial class ExamForm : Form
    {
        private SqlConnection connection = SQLServerConnection.connect(@"Data Source=DESKTOP-83J8IV6;Initial Catalog=Exam;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        private String operation = "creation";

        private Form1 caller;

        public ExamForm(Form1 form, String operation)
        {
            InitializeComponent();
            this.operation = operation;
            
            titre_picker.Text = ExamDataSource.getSelectedExam().titre;
            level_picker.Text = ExamDataSource.getSelectedExam().level;
            date_picker.Value = DateTime.ParseExact(ExamDataSource.getSelectedExam().date, "yyyy-mm-dd  hh:mm:ss" , CultureInfo.InvariantCulture);
            duree_picker.Text = ExamDataSource.getSelectedExam().durre.ToString();

            this.caller = form;
        }


        public ExamForm(Form1 form)
        {
            InitializeComponent();

            this.caller = form;
        }

        
        private void ExamForm_Load(object sender, EventArgs e)
        {
        
        }

        
        private void button_save_Click(object sender, EventArgs e)
        {
            ExamDAO examDAO = new ExamDAO(connection);
            int result;
            
            bool isValidOp = (titre_picker.Text.Length != 0 && 
                              level_picker.Text.Length != 0 && 
                              date_picker.Text.Length != 0  &&
                              duree_picker.Text.Length != 0
                              );
            if (!isValidOp)
            {
                label_err.Text = "please fill all fields.";
                label_err.ForeColor = Color.Red;
            }
            else
            {
                label_err.Text = "";
                if (operation == "creation")
                {
                    Exam exam = new Exam(titre_picker.Text, 
                                         level_picker.Text, 
                                         date_picker.Value.ToString("yyyy-mm-dd  hh:mm:ss"), 
                                         int.Parse(duree_picker.Text));
                    
                    result = examDAO.save(exam);
                    ExamDataSource.addExam(exam);

                    if (result > 0)
                    {
                        SuccessForm success = new SuccessForm();
                        success.ShowDialog();
                    }
                } 
                else
                {
                    String[] newData = new string[] { level_picker.Text,
                                                      date_picker.Value.ToString("yyyy-mm-dd  hh:mm:ss"),
                                                      duree_picker.Text,
                                                      titre_picker.Text };

                    result = examDAO.update(ExamDataSource.getSelectedExam(), newData);
                    
                    if (result > 0)
                    {
                        SuccessForm success = new SuccessForm();
                        success.ShowDialog();
                    }
                }
            }

        }

        private void reloadData(object sender, FormClosedEventArgs e)
        {
            caller.reload();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel_exam_formulaire_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
