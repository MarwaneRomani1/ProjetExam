using Microsoft.Data.SqlClient;
using ProjetExam.DataPackage.Models;
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

        public override int delete(Question t)
        {
            throw new NotImplementedException();
        }

        public override List<Question> getAll()
        {
            throw new NotImplementedException();
        }

        public override Question getOne(int id)
        {
            throw new NotImplementedException();
        }

        public override int save(Question t)
        {
            throw new NotImplementedException();
        }

        public override int update(Question t, string[] arguments)
        {
            throw new NotImplementedException();
        }
    }
}
