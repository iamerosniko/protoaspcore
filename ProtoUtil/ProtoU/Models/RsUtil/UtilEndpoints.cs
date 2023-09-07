using ProtoU.Models.Constants;

namespace ProtoU.Models.RsUtil
{
    public class UtilEndpoints
    {
        public UtilEndpoints(IConfiguration configuration)
        {
            Url = configuration[UtilConstants.Url].ToString();
            Crud = string.Format("{0}{1}", Url, configuration[UtilConstants.Crud].ToString());
            Login = string.Format("{0}{1}", Url, configuration[UtilConstants.Login].ToString());
            GetTeam = string.Format("{0}{1}", Url, configuration[UtilConstants.GetTeam].ToString());
        }
        public string? Url { get; set; }
        public string? Crud{ get; set; }
        public string? Login{ get; set; }
        public string? GetTeam{ get; set; }
    }
}
