﻿using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.Models;
using System.Collections.Generic;


namespace ProjetExam.DataPackage.DataAccessObject
{
    internal class ExamQuestionsDAO : DataAccessObject<Exam>
    {
        public ExamQuestionsDAO(SqlConnection connection) : base(connection) { }


        public override List<Exam> getAll()
        {
            List<Exam> exams = new List<Exam>();

            connection.Open();

            String query = "select * from Exam;";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader["id_exam"].ToString());
                String titre = reader["titre"].ToString();
                String level = reader["level"].ToString();
                DateTime date = DateTime.Parse(reader["date"].ToString());
                int durre = int.Parse(reader["durre"].ToString());
                Exam ex = new Exam(id,titre,level,date,durre);
                
                exams.Add(ex);
            }

            connection.Close();
            
            return exams;
        }

        public override Exam getOne(int id)
        {
            Exam exam = null;

            connection.Open();

            String query = "select * from Exam where i_exam =" + id + ";";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id_exam = int.Parse(reader["id_exam"].ToString());
                String titre = reader["titre"].ToString();
                String level = reader["level"].ToString();
                DateTime date = DateTime.Parse(reader["date"].ToString());
                int durre = int.Parse(reader["durre"].ToString());

                exam = new Exam(id_exam, titre ,level, date, durre);
            }

            connection.Close();

            return exam;
        }

        public override int save(Exam exam)
        {
            String query = "insert into Exam(level, date, durre, titre) VALUES('" + exam.level + "'," + "'" + exam.date.ToString() + "'," + "', 60, 'UML');";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            String getIdQuery = "SELECT SCOPE_IDENTITY()";
            SqlCommand command2 = new SqlCommand(getIdQuery, connection);
            int id = Convert.ToInt32(command2.ExecuteScalar());

            exam.id = id;

            connection.Close();
            return result;
        }
        
        public override int delete(Exam exam)
        {
            String query = "delete from Exam where id_exam=" + exam.id + ";";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        
        public override int update(Exam exam, string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}
