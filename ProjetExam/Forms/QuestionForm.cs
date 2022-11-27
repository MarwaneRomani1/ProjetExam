﻿using ProjetExam.DataPackage.DataAccessObject;
using ProjetExam.DataPackage.DatabaseConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetExam.DataPackage.Models;

namespace ProjetExam.Forms
{
    public partial class QuestionForm : Form
    {
        private SqlConnection connection = SQLServerConnection.connect(@"Data Source=DESKTOP-83J8IV6;Initial Catalog=Exam;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        private QuestionManager manager;
        private String type;

        public QuestionForm()
        {
            InitializeComponent();
        }

        public QuestionForm(QuestionManager manager)
        {
            InitializeComponent();
            this.manager = manager;
        }


        private void QuestionForm_Load(object sender, EventArgs e)
        {
            panel_question_form.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_normal_question_Click(object sender, EventArgs e)
        {
            panel_question_form.Visible = true;
            panel_choix.Visible = false;

            this.type = "ouverte";
            
        }

        private void button_qcm_Click(object sender, EventArgs e)
        {
            panel_question_form.Visible = true;
            panel_choix.Visible = true;

            this.type = "qcm";
        }

        private void button_enregistrer_Click(object sender, EventArgs e)
        {
            QuestionDAO questionDAO = new QuestionDAO(connection);

            if (type == "ouverte")
            {
                if (textBox_question.Text.Length == 0)
                {
                    label_error.Text = "entrer la question";
                    label_error.ForeColor = Color.White;
                    label_error.BackColor = Color.Red;
                }
                else
                {
                    String question = textBox_question.Text;
                    int note = int.Parse(textBox_note.Text);

                    Question q = new Question(question, note);

                    int result = questionDAO.save(q);
                    if (result > 0)
                    {
                        SuccessForm success = new SuccessForm();
                        success.ShowDialog();
                    }
                }
            }   
            else
            {
                if (textBox_question.Text.Length == 0 || comboBox_choix.Items.Count < 2)
                {
                    label_error.Text = "entrer la question et au moins deux choix.";
                    label_error.ForeColor = Color.White;
                    label_error.BackColor = Color.Red;
                }
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void reloadData(object sender, EventArgs e)
        {
            manager.reload();
        }

        private void reloadData(object sender, FormClosedEventArgs e)
        {
            manager.reload();
        }
    }
}