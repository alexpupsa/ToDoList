using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Model;
using ToDoList.Services.Interfaces;

namespace ToDoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        public ToDoController(IToDoService toDoService)
        {
            _toDoService = toDoService;
        }

        [HttpGet]
        [EnableCors("MyPolicy")]
        public IActionResult GetToDos()
        {
            return Ok(_toDoService.GetToDos());
        }

        [HttpPut]
        [EnableCors("MyPolicy")]
        public IActionResult AddToDo(ToDo item)
        {
            var result = _toDoService.AddTodo(item);
            if(result)
            {
                return NoContent();
            }
            else
            {
                return Conflict();
            }
        }
    }
}
