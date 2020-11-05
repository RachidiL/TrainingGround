using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //An abstract class says: you connot create me directly but anything which inherit from me get this code
    //An abstract class is an blend of an interface and base class
    public abstract class DataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }
        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }
}
