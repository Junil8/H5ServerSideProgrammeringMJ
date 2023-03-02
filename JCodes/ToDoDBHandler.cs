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
            var toDoList = context.ToDos.Where(x => x.User == username).ToList();
            return toDoList;
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
            var result = context.ToDos.SingleOrDefault(todo => todo.Id ==  id);

            context.ToDos.Remove(result);
            context.SaveChanges();
            return result;
        }
    }
}
