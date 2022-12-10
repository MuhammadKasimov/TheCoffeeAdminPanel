using System.Collections.Generic;
using System.Threading.Tasks;
using TheCoffeeAdminPanel.Enums;
using TheCoffeeAdminPanel.Service.DTOs;

namespace TheCoffeeAdminPanel.Interfaces
{
    public interface IUserService
    {
        ValueTask<Response<UserForViewDTO>> UpdateAsync(string login, string password, UserForUpdateDTO userForUpdateDTO);

        ValueTask<int> ChangeRoleAsync(int id, UserRole userRole);

        ValueTask<int> ChangePasswordAsync(string oldPassword, string newPassword);

        ValueTask<Response<IEnumerable<UserForViewDTO>>> GetAllAsync(PaginationParams @params);

        ValueTask<Response<UserForViewDTO>> GetAsync(int id);
        ValueTask<Response<UserForViewDTO>> GetAsync();

    }
}