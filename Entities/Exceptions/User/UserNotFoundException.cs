namespace Entities.Exceptions.User
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException(string? message) : base(message)
        {
        }
    }
}
