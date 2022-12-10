using System.Threading.Tasks;
using TheCoffeeAdminPanel.Service.DTOs;

namespace TheCoffeeAdminPanel.Service.Interfaces
{
    public interface IAuthService
    {
        ValueTask<Response<AuthToken>> Login(UserForLoginDTO dto);
    }
}
