using System;

namespace ToDoList.Model
{
    public class ToDo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public bool IsComplete { get; set; }
    }
}
