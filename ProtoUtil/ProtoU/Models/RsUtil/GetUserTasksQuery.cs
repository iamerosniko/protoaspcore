namespace ProtoU.Models.RsUtil
{
    public class GetUserTasksQuery
    {
        public GetUserTasksQuery() 
        {
            DateCoverageEnd = string.Empty;
            DateCoverageStart = string.Empty;
        }
        public int UserId { get; set; }
        public string DateCoverageStart{ get; set; }
        public string DateCoverageEnd{ get; set; }
    }
}
