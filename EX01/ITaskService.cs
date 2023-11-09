namespace EX01
{
  
    public interface ITaskService
    {
        public void AddTask(Task t);
        public void RemoveTask(Task t);
        public Task UpdateTask(Task t, string title);
        public List<Task> GetAllTask();
    }
}