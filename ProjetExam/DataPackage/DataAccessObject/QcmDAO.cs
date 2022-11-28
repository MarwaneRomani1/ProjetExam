using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetExam.DataPackage.DataAccessObject
{
    internal class QcmDAO : DataAccessObject<QcmQuestion>
    {
        public QcmDAO(SqlConnection connection) : base(connection)
        {
        }

        public override List<QcmQuestion> getAll()
        {
            throw new NotImplementedException();
        }

        public override QcmQuestion getOne(int id)
        {
            throw new NotImplementedException();
        }

        public override int save(QcmQuestion q)
        {
            String query = "INSERT INTO QcmQuestion(id_question) VALUES (" + q.id +");";
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();

            String getIdQuery = "SELECT SCOPE_IDENTITY()";
            SqlCommand command2 = new SqlCommand(getIdQuery, connection);
            int id = Convert.ToInt32(command2.ExecuteScalar());

            q.id_qcm = id;

            connection.Close();
            return result;
        }

        public override int update(QcmQuestion t, string[] arguments)
        {
            throw new NotImplementedException();
        }
        public override int delete(QcmQuestion t)
        {
            throw new NotImplementedException();
        }
    }
}
