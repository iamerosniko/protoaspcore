using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;
using ProtoU.Models.RsUtil;
using System.Reflection;
using System.Text;

namespace ProtoU.Controllers.RsUtilServices
{
    public class RsUtilConnectors
    {
        IConfiguration _configuration;
        UtilEndpoints _endpoints;
        public RsUtilConnectors(IConfiguration configuration) 
        {
            _configuration = configuration;
            _endpoints = new UtilEndpoints(_configuration);

        }
        public async Task<EmployeeUtilResponse> GetEmployeeUtilResponse(GetUserTasksQuery query)
        {
            string methodName = MethodBase.GetCurrentMethod().Name;

            try
            {
                var response = await PostAction(query, _endpoints.Crud);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<EmployeeUtilResponse>(responseBody);
                }
                else
                {
                    return new EmployeeUtilResponse { ErrorCode = 1, ErrorMessage=string.Format("Unsuccessful request from: {0} method", methodName)};
                }
            }
            catch
            {
                throw;
            }
        }

        private static async Task<HttpResponseMessage> PostAction(object requestData, string apiUrl)
        {
            try
            {
                using HttpClient client = new();

                // Serialize the object to JSON
                string jsonRequestBody = JsonConvert.SerializeObject(requestData);

                // Create a StringContent with the JSON data
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                // Send a POST request to the API
                return await client.PostAsync(apiUrl, content);
            }
            catch 
            {
                throw;
            }
        }
    }
}
