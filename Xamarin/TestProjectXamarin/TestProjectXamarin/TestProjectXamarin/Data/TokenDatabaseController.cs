using SQLite;
using TestProjectXamarin.Model;
using Xamarin.Forms;

namespace TestProjectXamarin.Data
{
    public class TokenDatabaseController
    {
        static object locker = new object();

        SQLiteConnection database;

        public TokenDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<Token>();
        }

        public Token GetToken()
        {
            lock (locker)
            {
                if (database.Table<User>().Count() == 0)
                    return null;
                else
                    return database.Table<Token>().First();
            }
        }

        public int SaveToken(Token user)
        {
            lock (locker)
            {
                if (user.Id != 0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                    return database.Insert(user);
            }
        }

        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<Token>(id);
            }
        }
    }
}
