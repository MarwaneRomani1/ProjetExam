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
    internal class ChoixDAO
    {
        private SqlConnection connection;

        public ChoixDAO(SqlConnection connection)
        {
            this.connection = connection;
        }

        public int save(String choix, bool isCorrect, int id_qcm)
        {
            byte correct = 0;
            if (isCorrect)
                correct = 1;

            String query = "INSERT INTO QcmChoix(choix,correct, id_qcm) VALUES ('" + choix +"'," + correct +"," + id_qcm + ");";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            connection.Close();
            return result;
        }

        public int delete(Question q)
        {
            String query0 = "SELECT id_qcm FROM QcmQuestion WHERE id_question = " + q.id + ";";
            SqlCommand command0 = new SqlCommand(query0, connection);
            connection.Open();
            SqlDataReader reader = command0.ExecuteReader();
            int id_qcm = 0;
            while (reader.Read())
            {
                id_qcm = int.Parse(reader["id_qcm"].ToString());
            }
            connection.Close();

            String query = "DELETE FROM QcmChoix WHERE id_qcm = " + id_qcm + ";";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
