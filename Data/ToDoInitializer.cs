using H5ServerSideProgrammeringMJ.Models;

namespace H5ServerSideProgrammeringMJ.Data
{
    public static class ToDoInitializer 
    {
        public static void Initialize(ToDoContext context)
        {
            context.Database.EnsureCreated();

            if (context.ToDos.Any())
            {
                return;   
            }
            var todos = new List<ToDo>
            {
                new ToDo { Id=1, TaskName="name1", TaskDescription = "desc1"},
                new ToDo { Id=2, TaskName="name2", TaskDescription = "desc2"},
                new ToDo { Id=3, TaskName="name3", TaskDescription = "desc3"},
            };
            todos.ForEach(todo => context.ToDos.Add(todo));
            context.SaveChanges();

        }
    }
}
