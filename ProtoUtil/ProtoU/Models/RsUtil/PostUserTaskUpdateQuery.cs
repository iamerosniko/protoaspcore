namespace ProtoU.Models.RsUtil
{
    public class PostUserTaskUpdateQuery
    {
        public PostUserTaskUpdateQuery() 
        {
            MetricsDateRange= new MetricsDateRange();
            UpdateTasks=new List<UpdateTasks>();
        }
        public int UserId { get; set; }
        public MetricsDateRange MetricsDateRange { get; set; }
        public IEnumerable<UpdateTasks> UpdateTasks { get; set; }
    }
    public class UpdateTasks
    {
        public UpdateTasks()
        {
            DateModified= DateTime.Now.ToString("yyyy-MM-dd");
            TaskDate= string.Empty;
            TaskDescription= string.Empty;
            TaskTypeName= string.Empty;
        }
        public string DateModified { get; set; }
        public int Id { get; set; }
        public string TaskDate { get; set; }
        public string TaskDescription { get; set; }
        public double TaskDuration { get; set; }
        public int TaskType{ get; set; }
        public string TaskTypeName{ get; set; }
        public int UserId { get; set; }

    }
}
