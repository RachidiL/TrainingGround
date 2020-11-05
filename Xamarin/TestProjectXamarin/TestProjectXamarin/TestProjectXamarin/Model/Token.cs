using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectXamarin.Model
{
    public class Token
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string AccessToken { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime ExpireDate { get; set; }
        public int ExpireIn { get; internal set; }
    }
}
