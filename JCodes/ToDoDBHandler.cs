using H5ServerSideProgrammeringMJ.Models;
using H5ServerSideProgrammeringMJ.Data;
using Microsoft.AspNetCore.DataProtection;

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
        public List<ToDo> ReadAll(string username, ToDoContext context)
        {
            List<ToDo> todoList = context.ToDos.Where(x => x.User == username).ToList();

            return todoList;
        }
        public ToDo ReadById(string username, int id, ToDoContext context)
        {
            ToDo todo = context.ToDos.Where(a => a.User == username).FirstOrDefault(x => x.Id == id);
            return todo;
        }
        // Update
        public ToDo Update(string taskName, string TaskDescription, int id, ToDoContext context)
        {
            var result = context.ToDos.SingleOrDefault(todo => todo.Id == id);

            result.TaskName = taskName;
            result.TaskDescription = TaskDescription;

            context.SaveChanges();
            return result;
        }
        // Delete
        public ToDo Delete(int id, ToDoContext context)
        {
            var result = context.ToDos.SingleOrDefault(todo => todo.Id == id);

            context.ToDos.Remove(result);
            context.SaveChanges();
            return result;
        }
    }
}
