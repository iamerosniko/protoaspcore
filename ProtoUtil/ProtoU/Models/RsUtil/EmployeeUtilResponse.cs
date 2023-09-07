namespace ProtoU.Models.RsUtil
{
    public class EmployeeUtilResponse
    {
        public EmployeeUtilResponse() 
        {
            CompletedTasks = new List<CompletedTasks>();
            ErrorMessage = string.Empty;
        }
        public int UserId { get; set; }
        public IEnumerable<CompletedTasks> CompletedTasks { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CompletedTasks
    {
        public CompletedTasks()
        {
            DateCompleted = string.Empty;
            TaskTypeName = string.Empty;
            TaskDescription = string.Empty;
        }
        public string DateCompleted { get; set; }
        public string TaskTypeName { get; set; }
        public string TaskDescription { get; set; }
        public int TaskId { get; set; }
        public double TaskDuration { get; set; }
        public int RecordId { get; set; }
    }
}
