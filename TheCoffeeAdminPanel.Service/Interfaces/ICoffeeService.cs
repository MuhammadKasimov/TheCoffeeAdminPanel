using System.Collections.Generic;
using System.Threading.Tasks;
using TheCoffeeAdminPanel.Service.DTOs;

namespace TheCoffeeAdminPanel.Interfaces
{
    public interface ICoffeeService
    {
        ValueTask<Response<CoffeeForViewDTO>> CreateAsync(CoffeeForCreationDTO coffeeForCreationDTO);

        ValueTask<Response<CoffeeForViewDTO>> UpdateAsync(string id, string attachmentId, CoffeeForCreationDTO coffeeForCreationDTO, string token);

        ValueTask<bool> DeleteAsync(string id);

        ValueTask<Response<IEnumerable<CoffeeForViewDTO>>> GetAllAsync(
            PaginationParams @params);

        ValueTask<Response<CoffeeForViewDTO>> GetAsync(string id);
    }
}