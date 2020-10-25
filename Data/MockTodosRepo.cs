
using System.Collections.Generic;
using Todos.Models;

namespace Todos.Data
{
    public class MockTodosRepo : ITodosRepo
    {
        public Todo GetTodoById(int id)
        {
            // throw new System.NotImplementedException();
            return new Todo{Id=0, Description="Test Description", Title="Test Title"};
        }

        public IEnumerable<Todo> GetTodos()
        {
            // throw new System.NotImplementedException();
            var todos = new List<Todo> {
                new Todo{Id=0, Description="Test Description 1", Title="Test Title 1"},
                new Todo{Id=1, Description="Test Description 2", Title="Test Title 2"},
                new Todo{Id=2, Description="Test Description 3", Title="Test Title 3"},
            };

            return todos;
        }
    }
}