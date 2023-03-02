using Microsoft.EntityFrameworkCore;
using H5ServerSideProgrammeringMJ.Models;
using H5ServerSideProgrammeringMJ.Data;

namespace H5ServerSideProgrammeringMJ.JCodes
{
    public class ToDoDBHandler
    {
        // Create
        public ToDo Create(string taskName, string TaskDescription, string username, ToDoContext context)
        {
            var todo = new ToDo
            {
                TaskName = taskName,
                TaskDescription = TaskDescription,
                User = username
            };
            context.ToDos.Add(todo);
            context.SaveChanges();
            return todo;
        }
        // Read
        public List<ToDo> Read(string username, ToDoContext context)
        {
            var toDoList = context.ToDos.ToList();
            return toDoList;
        }
        // Update
        // Delete




    }
}
