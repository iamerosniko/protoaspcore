namespace ProtoU.Models.RsUtil
{
    public class PostUserTaskDeleteQuery
    {
        public PostUserTaskDeleteQuery() { 
            MetricsDateRange = new MetricsDateRange();
            DeleteTasks = new List<string>();
        }
        public int UserId { get; set; }
        public MetricsDateRange MetricsDateRange { get; set; }
        public IEnumerable<string> DeleteTasks { get; set; }
    }
    
}
