using Microsoft.AspNetCore.Identity;

namespace Entities.DataTransferObjects.UserDto
{
    public record UserDto
    {
        public int UserId { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; } 
        public string? UserName { get; init; }
        public string? Email { get; init; }
        public string? PhoneNumber { get; init; }
        public ICollection<IdentityRole>? Roles { get; init; }
    }
}
