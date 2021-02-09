using System;
using System.IO;
using SQLite;
using SqliteSample.Database;
using SqliteSample.Droid.Database;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDbDroid))]
namespace SqliteSample.Droid.Database
{
    public class SQLiteDbDroid : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "Test.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}