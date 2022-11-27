using Azure.Core;
using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.DataAccessObject
{
    internal class ExQuestionsDAO : DataAccessObject<Question>
    {
        private int idExam;
        public ExQuestionsDAO(SqlConnection connection, int idExam) : base(connection)
        {
            this.idExam = idExam;
        }


        public override List<Question> getAll()
        {
            List<Question> questions = new List<Question>();

            connection.Open();

            String query = "SELECT q.question, q.note FROM Exam e, Question q, ExamQuestion eq WHERE e.id_exam =" + idExam + "and e.id_exam = eq.id_exam and q.id_question = eq.id_question;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String question = reader["question"].ToString();
                int note = int.Parse(reader["note"].ToString());

                Question quest = new Question(question, note);

                questions.Add(quest);
            }

            connection.Close();

            return questions;
        }

        public override Question getOne(int id)
        {
            throw new NotImplementedException();
        }

        public override int save(Question question)
        {
            String query = "INSERT INTO ExamQuestion(id_exam, id_question) VALUES(" + idExam + "," + question.id + ");";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            connection.Close();
            return result;
        }

        public override int update(Question t, string[] arguments)
        {
           throw new NotImplementedException();
        }

        public override int delete(Question t)
        {
            throw new NotImplementedException();
        }
    }
}
