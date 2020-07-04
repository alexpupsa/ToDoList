using System.Collections.Generic;
using System.Linq;
using ToDoList.Model;
using ToDoList.Services.Interfaces;

namespace ToDoList.Services
{
    public class ToDoService : IToDoService
    {
        private readonly ToDoContext _context;

        public ToDoService(ToDoContext context)
        {
            _context = context;
        }

        public bool AddTodo(ToDo item)
        {
            try
            {
                _context.ToDos.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<ToDo> GetToDos()
        {
            return _context.ToDos.ToList();
        }
    }
}
