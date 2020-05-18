using System.ComponentModel.DataAnnotations;

namespace SagonBackendSDK.V1.Contracts.Requests.Authentication
{
    public class RegisterRequest
    {
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}