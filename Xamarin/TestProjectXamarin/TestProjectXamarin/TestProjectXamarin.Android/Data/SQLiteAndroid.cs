using System.IO;
using SQLite;
using TestProjectXamarin.Data;
using TestProjectXamarin.Droid.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteAndroid))]

namespace TestProjectXamarin.Droid.Data
{
    public class SQLiteAndroid : ISQLite
    {
        public SQLiteAndroid()
        {

        }
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}