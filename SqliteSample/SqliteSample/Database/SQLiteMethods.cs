using SQLite;
using SqliteSample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqliteSample.Database
{
    public class SQLiteMethods : ISQLiteMethods
    {
        private SQLiteAsyncConnection _connection;

        public SQLiteMethods(ISQLiteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<Todo>();
        }

        public async Task AddTodo(Todo todo)
        {
            await _connection.InsertAsync(todo);
        }

        public async Task DeleteTodo(Todo todo)
        {
            await _connection.DeleteAsync(todo);
        }

        public async Task<Todo> GetTodo(int id)
        {
            return await _connection.FindAsync<Todo>(id);
        }

        public async Task<IEnumerable<Todo>> GetTodoAsync()
        {
            return await _connection.Table<Todo>().ToListAsync();
        }

        public async Task UpdateTodo(Todo todo)
        {
            await _connection.UpdateAsync(todo);
        }

    }
}
