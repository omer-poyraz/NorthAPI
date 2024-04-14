namespace Entities.Exceptions.User
{
    public class UserBadRequestException : BadRequestException
    {
        public UserBadRequestException(string? message) : base(message)
        {
        }
    }
}
