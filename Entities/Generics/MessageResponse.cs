using System.Runtime.InteropServices;

namespace AuthenticationLogin.Entities.Generics
{
    public class MessageResponse<T> where T : class
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Response { get; set; }
    }
}
