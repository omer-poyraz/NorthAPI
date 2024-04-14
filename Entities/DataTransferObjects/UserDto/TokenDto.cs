namespace Entities.DataTransferObjects.UserDto
{
    public class TokenDto
    {
        public string? AccessToken { get; init; }
        public string? RefreshToken { get; init; }
    }
}
