namespace Agence.Core.Model.Response
{
    using System.Net;

    public class BaseResponse
    {
        public BaseResponse()
        {

        }   
        
        public bool IsSucceded { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; } 
    }
}
