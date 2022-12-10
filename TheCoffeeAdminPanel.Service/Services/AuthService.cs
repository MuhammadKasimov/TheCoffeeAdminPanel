using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TheCoffeeAdminPanel.Service.Constants;
using TheCoffeeAdminPanel.Service.DTOs;
using TheCoffeeAdminPanel.Service.Interfaces;

namespace TheCoffeeAdminPanel.Service.Services
{
    public class AuthService : IAuthService
    {
        public async ValueTask<Response<AuthToken>> Login(UserForLoginDTO dto)
        {
            using (HttpClient client = new HttpClient())
            {
                string userLoging = JsonConvert.SerializeObject(dto);
                StringContent content = new StringContent(userLoging, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(AppConstants.AUTH_CONTROLLER + "Login", content);
                if (!response.IsSuccessStatusCode)
                {
                    return new Response<AuthToken>()
                    {
                        Message = await response.Content.ReadAsStringAsync(),
                        StatusCode = (int)response.StatusCode,
                        Value = null
                    };
                }
                return new Response<AuthToken>()
                {
                    Message = await response.Content.ReadAsStringAsync(),
                    StatusCode = (int)response.StatusCode,
                    Value = JsonConvert.DeserializeObject<AuthToken>(await response.Content.ReadAsStringAsync())
                };

            }
        }

    }
}
