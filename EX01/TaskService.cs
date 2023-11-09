namespace EX01
{
    public class TaskService : ITaskService
    {
        public List<Task> ListOfTasks = new List<Task>();
        Task t1 = new Task() { Title = "java", Discription = "good lang", Level = Priority.max };
        Task t2 = new Task() { Title = "hm", Discription = "good doing", Level = Priority.mid };
        Task t3 = new Task() { Title = "do schedule", Discription = "nice lang", Level = Priority.min };

        public void AddTask(Task t)
        {
            ListOfTasks.Add(t);
        }

        public void RemoveTask(Task t)
        {
            ListOfTasks.Remove(t);
        }

        public Task UpdateTask(Task t, string title)
        {
            int index = ListOfTasks.FindIndex(t1 => t1.Title == title);
            if (index != -1)
                ListOfTasks[index] = t;
            return t;
        }
        public List<Task> GetAllTask()
        {
            return ListOfTasks;
        }
    }
}
