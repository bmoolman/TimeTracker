using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TimeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            SQLiteConnection sqlite_conn =
                new SQLiteConnection("Data Source=database.sqlite;Version=3;");

            sqlite_conn.Open();
            sqlite_conn.Close();

        }
    }
}
