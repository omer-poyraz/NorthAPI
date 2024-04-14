namespace Entities.Exceptions.User
{
    public class RefreshTokenBadRequestException : BadRequestException
    {
        public RefreshTokenBadRequestException() : base("Yanlış token isteği!")
        {
        }
    }
}
