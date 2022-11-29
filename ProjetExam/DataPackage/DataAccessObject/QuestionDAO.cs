using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.Models;
using ProjetExam.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.DataAccessObject
{
    internal class QuestionDAO : DataAccessObject<Question>
    {
        public QuestionDAO(SqlConnection connection) : base(connection) { }

        public override List<Question> getAll()
        {
            List<Question> questions = new List<Question>();

            connection.Open();

            String query = "select * from Question;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["id_question"].ToString());
                
                String question = reader["question"].ToString();
                
                int note = int.Parse(reader["note"].ToString());
                
                Question ques = new Question(id,question,note);

                questions.Add(ques);
            }

            connection.Close();

            return questions;
        }

        public override Question getOne(int id)
        {
            Question question = null;

            connection.Open();

            String query = "select * from Question where id=" + id + ";";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                String quest = reader["question"].ToString();
                int note = int.Parse(reader["note"].ToString());
                question = new Question(id, quest, note);
            }

            connection.Close();

            return question;
        }

        public override int save(Question question)
        {
            String query = "insert into Question(question,note) VALUES ('" + question.question + "',"+ question.note + ");";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            String getIdQuery = "SELECT SCOPE_IDENTITY()";
            SqlCommand command2 = new SqlCommand(getIdQuery, connection);
            int id = Convert.ToInt32(command2.ExecuteScalar());
            
            question.id = id;

            connection.Close();
            return result;
        }

        public override int update(Question t, string[] arguments)
        {
            throw new NotImplementedException();
        }

        public override int delete(Question q)
        {
            String query = "DELETE FROM Question WHERE id_question = " + q.id + ";";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public List<Question> getAllQuestionsNotInserted(int examId)
        {
            List<Question> questions = new List<Question>();

            connection.Open();

            String query = "SELECT id_question, question, note FROM Question q WHERE q.id_question not in (select  id_question from ExamQuestion WHERE id_exam =" + examId + ");";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["id_question"].ToString());

                String question = reader["question"].ToString();

                int note = int.Parse(reader["note"].ToString());

                Question ques = new Question(id, question, note);

                questions.Add(ques);
            }

            connection.Close();

            return questions;

        }

    }
}
