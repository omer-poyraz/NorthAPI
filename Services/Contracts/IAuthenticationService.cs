using Entities.DataTransferObjects.UserDto;
using Microsoft.AspNetCore.Identity;

namespace Services.Contracts
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegisterDto registerDto);
        Task<bool> ValidUser(UserForAuthenticationDto authenticationDto);
        Task<TokenDto> CreateToken(bool populateExpire);
        Task<TokenDto> RefreshToken(TokenDto tokenDto);
    }
}
