using Day_1.Models;

namespace Day_1.Data
{
    public static class TodoRepository
    {
        public static List<Todo> Todos = new List<Todo>
        {
            new Todo { Id = 1, Title = "Learn API", IsCompleted = false },
            new Todo { Id = 2, Title = "Build Project", IsCompleted = true }
        };
    }
}
