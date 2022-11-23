using Microsoft.Data.SqlClient;

namespace ProjetExam.DataPackage.DatabaseConnection
{
    internal class SQLServerConnection
    {
        private static SqlConnection connection = null;
        private SQLServerConnection()
        {
        }

        public static SqlConnection connect(String url)
        {
            if (connection != null)
                return connection;

            connection = new SqlConnection(url);
            return connection;

        }
    }
}
