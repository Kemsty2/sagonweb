using System.ComponentModel.DataAnnotations;

namespace SagonWeb.DTOs.Users
{
    public class LoginUserDto
    {
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }
    }
}