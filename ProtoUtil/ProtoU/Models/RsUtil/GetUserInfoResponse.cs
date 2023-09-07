namespace ProtoU.Models.RsUtil
{
    public class GetUserInfoResponse
    {
        public GetUserInfoResponse()
        {
            Email= string.Empty;
            ExceptionMessage = string.Empty;
            FirstName = string.Empty;
            LastName = string.Empty;
            Roles = new List<Roles>();
            StatusDescription = string.Empty;
            Token= string.Empty;
            TransactionId = string.Empty;
        }
        public string Email { get; set; }
        public string ExceptionMessage { get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public IEnumerable<Roles> Roles { get; set; }
        public string? StackTrace { get; set; }
        public int Status{ get; set; }
        public string StatusDescription { get; set; }
        public string Token { get; set; }
        public string TransactionId { get; set; }
        public int UserId { get; set; }
    }

    public class Roles
    {
        public Roles()
        {
            RoleDescription = string.Empty;
        }
        public int RoleId { get; set; }
        public string RoleDescription { get; set; }
    }
}
