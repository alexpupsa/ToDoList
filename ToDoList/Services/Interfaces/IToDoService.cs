using System.Collections.Generic;
using ToDoList.Model;

namespace ToDoList.Services.Interfaces
{
    public interface IToDoService
    {
        List<ToDo> GetToDos();
        bool AddTodo(ToDo item);
    }
}
