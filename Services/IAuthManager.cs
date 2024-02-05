using System.Threading.Tasks;
using HotelListing.Models;

namespace HotelListing.Services
{
    public interface IAuthManager
    {
        public Task<string> CreateToken();
        public Task<bool> ValidateUser(LoginUserDTO loginUserDTO);    
    }
}