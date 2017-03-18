using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace CleverSharp.Helper
{
    internal class WebHelper
    {
        static string JSON_ERROR = "error";

        public class JsonResult
        {
            public bool IsError { get; set; }
            public string exeption { get; set; }
            public string json { get; set; }
        }

      

        public JsonResult GetRequest(string url,string authHeader)
        {
            try
            {
                string rawJsonResult = GetRequestWithException(url,authHeader).GetAwaiter().GetResult();

                if (string.IsNullOrEmpty(rawJsonResult) || rawJsonResult.Equals(JSON_ERROR))
                {
                    return new JsonResult { json = rawJsonResult, exeption = "unknown error", IsError = true };
                }

                return new JsonResult { json = rawJsonResult };
            }
            catch (Exception ex)
            {
                return new JsonResult { exeption = ex.Message, IsError = true };
            }
        }

        


        async Task<string> GetRequestWithException(string url,string authHeader)
        {
            string responseJson = string.Empty;
            HttpClient client = new HttpClient();            
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + authHeader);

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                responseJson =await response.Content.ReadAsStringAsync();
            }
            catch (Exception)
            {                
                    return JSON_ERROR;
            }
            return responseJson;
        }

       
    }
}
