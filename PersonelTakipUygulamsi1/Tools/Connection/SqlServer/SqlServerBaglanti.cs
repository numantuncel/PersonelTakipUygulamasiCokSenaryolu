using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PersonelTakipUygulamsi1.Tools.Connection.SqlServer
{
    /* Verinin Üzerine Tıklayıp Ctrl H ile tümünün ismini değiştirebilriz yeni simi yazdıkdan sonra acılan pencere de sağda tümü ikonuna tıklayın*/
    public class SqlServerBaglanti
    {
        private static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["PersonelTakipSqlServer"].ConnectionString);
                }
                return _connection;
            }
            set
            {
                _connection = value;
            }
        }
        public static void BaglantiAc()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }

        }
        public static void BaglantiKapat()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}

