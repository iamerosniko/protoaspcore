using Microsoft.AspNetCore.Mvc;
using ProtoU.Controllers.RsUtilServices;
using ProtoU.Models.Constants;
using ProtoU.Models.RsUtil;
using System.Collections;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProtoU.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        IConfiguration _configuration;
        public TestController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        IDictionary data = Environment.GetEnvironmentVariables();
        // GET: api/<TestController>
        [HttpGet]
        public object Get()
        {
            //UtilEndpoints ue = new UtilEndpoints(_configuration);
            RsUtilConnectors r = new RsUtilConnectors(_configuration);

            return r.GetEmployeeUtilResponse(new GetUserTasksQuery
            {
                DateCoverageEnd="2022-01-31",
                DateCoverageStart="2022-01-01",
                UserId =254482
            });

            //return new string[] { _configuration[UtilConstants.GetTeam].ToString() };
            //return MonthRange.GetMonthRangeConstants(2020, 2);
            //return new string?[] { "value1", HttpContext.User.Identities.FirstOrDefault().Name };
        }

       
    }
}
