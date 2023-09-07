namespace ProtoU.Models.RsUtil
{
    public class PostLoginQuery
    {
        public PostLoginQuery()
        {
            UserId = string.Empty;
            Password = string.Empty;
        }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
