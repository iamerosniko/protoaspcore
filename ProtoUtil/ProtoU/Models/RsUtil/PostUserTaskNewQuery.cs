namespace ProtoU.Models.RsUtil
{
    public class PostUserTaskNewQuery
    {
        public PostUserTaskNewQuery() 
        {
            NewTasks = new List<NewTasks>();
            MetricsDateRange= new MetricsDateRange(); 
        }
        public int UserId { get; set; }
        public MetricsDateRange MetricsDateRange{ get; set; }
        public IEnumerable<NewTasks> NewTasks { get; set; }
    }
    public class NewTasks
    {
        public NewTasks()
        {
            TaskTypeName= string.Empty;
            TaskDescription= string.Empty;
            TaskDate= string.Empty;
        }
        public int UserId { get; set; }
        public string TaskTypeName { get; set; }
        public string TaskDescription { get; set; }
        public double TaskDuration { get; set; }
        public string TaskDate { get; set; }
        public int TaskType { get; set; }
    }
}
