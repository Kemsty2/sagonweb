namespace SagonBackendSDK.V1.Contracts.Requests.Authentication
{
    public class UpdatePasswordRequest
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}