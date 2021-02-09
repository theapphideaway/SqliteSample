using SqliteSample.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqliteSample.Database
{
    public interface ISQLiteMethods
    {
        Task<IEnumerable<Todo>> GetTodoAsync();
        Task<Todo> GetTodo(int id);
        Task AddTodo(Todo todo);
        Task UpdateTodo(Todo todo);
        Task DeleteTodo(Todo todo);
    }
}
