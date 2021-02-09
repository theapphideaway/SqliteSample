using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteSample.Database
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
