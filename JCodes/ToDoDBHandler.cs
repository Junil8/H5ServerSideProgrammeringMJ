using Microsoft.EntityFrameworkCore;
using H5ServerSideProgrammeringMJ.Models;
using H5ServerSideProgrammeringMJ.Data;

namespace H5ServerSideProgrammeringMJ.JCodes
{
    public class ToDoDBHandler
    {
        // Create
        public ToDo Create(string username, ToDoContext context)
        {

            var todo = new ToDo
            {
                TaskName = "test",
                TaskDescription = "test",
                User = "test"
            };
            context.ToDos.Add(todo);
            context.SaveChanges();
            return todo;
        }
        // Read
        //public List<ToDo> Read(string username, ToDoContext context)
        //{

        //}

        // Update


        // Delete




    }
}
