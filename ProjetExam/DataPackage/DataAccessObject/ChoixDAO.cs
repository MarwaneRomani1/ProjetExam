using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.Models;
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
    }
}
