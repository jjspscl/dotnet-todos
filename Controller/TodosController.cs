using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Todos.Data;
using Todos.Models;

namespace Todos.Controller {

    [Route("api/todos/")] // [controller]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosRepo _repository;
        // private readonly MockTodosRepo _repository = new MockTodosRepo();
        
        public TodosController(ITodosRepo repository)
        {
            _repository = repository;     
        }
        
        [HttpGet]
        public ActionResult <IEnumerable<Todo>> GetAllTodos(){
            var todosItems = _repository.GetTodos();

            return Ok(todosItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Todo> GetTodoById(int id){
            var todoItem = _repository.GetTodoById(id);
            return todoItem;
        }
    }
}