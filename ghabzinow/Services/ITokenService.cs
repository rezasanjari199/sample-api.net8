using ghabzinow.Models;
using System.Security.Claims;

namespace ghabzinow.Services
{
    public interface ITokenService
    {
        string GenerateAccessToken(User user,int day);
        bool VerifyToken(string token);
        int UserId (string token);
      
    }
}
