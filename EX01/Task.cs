namespace EX01
{
    public enum Priority
    {
       max,
       mid,
       min
    }

    public class Task
    {
        public string Title { get; set; }
        public string Discription { get; set; }
        public  string Date { get; set; }
        public Priority Level { get; set; }
    }
}
