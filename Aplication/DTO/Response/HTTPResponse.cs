using System.Net;

namespace Application.DTO.Response
{
    public class HTTPResponse<T> where T : class
    {
        public HTTPResponse()
        {
            Message = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public string Status {  get; set; }
        public List<string> Message { get; set; }
        public T Result { get; set; }

    }
}
