using System;
using System.IO;
using SQLite;
using TestProjectXamarin.Data;
using TestProjectXamarin.iOS.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteIOS))]

namespace TestProjectXamarin.iOS.Data
{
    public class SQLiteIOS : ISQLite
    {
        public SQLiteIOS()
        {

        }
        public SQLiteConnection GetConnection()
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var LibraryPath = Path.Combine(documentPath, "...", "Library");
            var path = Path.Combine(LibraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}