using System.Collections.Generic;
using Todos.Models;

namespace Todos.Data {
    public interface ITodosRepo
    {
        IEnumerable<Todo> GetTodos();
        Todo GetTodoById(int id);

    }
}