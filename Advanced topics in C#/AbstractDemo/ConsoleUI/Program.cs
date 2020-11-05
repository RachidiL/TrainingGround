using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DataAccess> databases = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess()
            };

            foreach (var db in databases)
            {
                db.LoadConnectionString("demo");
                db.LoadData("SELECT * FROM TABLE");
                db.SaveData("INSERT INTO TABLE");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
