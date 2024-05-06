using System.Net;

namespace ghabzinow.ViewModel
{
    public class Response
    {
    }
    public class SuccessResponce<T>
    {
        public bool success { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }

    public class SuccessResponceV2<T>
    {
        public HttpStatusCode ResultCode { get; set; }
        public string Status { get; set; }
        public T Data { get; set; }
    }
    public class ErrorResponce
    {
        public bool success { get; set; }
        public string message { get; set; }
        public object data { get; set; }
        public int? errorCode { get; set; }
    }
    public class SuccessResponceList<T>
    {
        public bool success { get; set; }
        public string message { get; set; }
        public List<T> data { get; set; }
    }
    public class ErrorDto
    {
        public List<string> ErrorMessages { get; set; }
    }
}
