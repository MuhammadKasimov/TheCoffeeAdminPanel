using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TheCoffeeAdminPanel.Interfaces;
using TheCoffeeAdminPanel.Service.Constants;
using TheCoffeeAdminPanel.Service.DTOs;

namespace TheCoffeeAdminPanel.Service.Services
{
    public class CoffeeService : ICoffeeService
    {
        public async ValueTask<Response<CoffeeForViewDTO>> CreateAsync(CoffeeForCreationDTO coffeeForCreationDTO)
        {
            using (HttpClient client = new HttpClient())
            {

                MultipartFormDataContent multipart = new MultipartFormDataContent();
                string name = Guid.NewGuid().ToString("N");
                multipart.Add(new StreamContent(coffeeForCreationDTO.Image), name, name + ".png");

                var responce = await client.PostAsync(AppConstants.COFFEE_CONTROLLER +
                    $"?name={coffeeForCreationDTO.Name}&description={coffeeForCreationDTO.Description}&price={coffeeForCreationDTO.Price}", multipart);

                if (!responce.IsSuccessStatusCode)
                {
                    return new Response<CoffeeForViewDTO>()
                    {
                        Message = await responce.Content.ReadAsStringAsync(),
                        StatusCode = (int)responce.StatusCode,
                    };
                }

                return new Response<CoffeeForViewDTO>()
                {
                    StatusCode = (int)responce.StatusCode,
                    Value = JsonConvert.DeserializeObject<CoffeeForViewDTO>(await responce.Content.ReadAsStringAsync())
                };
            };
        }

        public async ValueTask<bool> DeleteAsync(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync(AppConstants.COFFEE_CONTROLLER + id);

                return response.IsSuccessStatusCode;
            }
        }

        public async ValueTask<Response<IEnumerable<CoffeeForViewDTO>>> GetAllAsync(PaginationParams @params)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(AppConstants.COFFEE_CONTROLLER + $"?PageIndex={@params.PageIndex}&PageSize={@params.PageSize}");

                if (!response.IsSuccessStatusCode)
                {
                    return new Response<IEnumerable<CoffeeForViewDTO>>()
                    {
                        Message = await response.Content.ReadAsStringAsync(),
                        StatusCode = (int)response.StatusCode,
                    };
                }
                return new Response<IEnumerable<CoffeeForViewDTO>>()
                {
                    StatusCode = (int)response.StatusCode,
                    Value = JsonConvert.DeserializeObject<IEnumerable<CoffeeForViewDTO>>(await response.Content.ReadAsStringAsync())
                };
            }
        }

        public async ValueTask<Response<CoffeeForViewDTO>> GetAsync(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(AppConstants.COFFEE_CONTROLLER + id);

                if (!response.IsSuccessStatusCode)
                {
                    return new Response<CoffeeForViewDTO>()
                    {
                        Message = await response.Content.ReadAsStringAsync(),
                        StatusCode = (int)response.StatusCode,
                    };
                }
                return new Response<CoffeeForViewDTO>()
                {
                    StatusCode = (int)response.StatusCode,
                    Value = JsonConvert.DeserializeObject<CoffeeForViewDTO>(await response.Content.ReadAsStringAsync())
                };
            }
        }

        public async ValueTask<Response<CoffeeForViewDTO>> UpdateAsync(string id, string attachmentId, CoffeeForCreationDTO coffeeForCreationDTO, string token)
        {
            using (HttpClient client = new HttpClient())
            {
                MultipartFormDataContent formData = new MultipartFormDataContent();
                formData.Add(new StreamContent(coffeeForCreationDTO.Image), "formFile", "image.png");


                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var responce = await client.PutAsync(AppConstants.COFFEE_CONTROLLER + id +
                    $"?name={coffeeForCreationDTO.Name}&description={coffeeForCreationDTO.Description}&price={coffeeForCreationDTO.Price}&AttachmentId={attachmentId}", formData);

                if (!responce.IsSuccessStatusCode)
                {
                    return new Response<CoffeeForViewDTO>()
                    {
                        Message = await responce.Content.ReadAsStringAsync(),
                        StatusCode = (int)responce.StatusCode,
                    };
                }

                return new Response<CoffeeForViewDTO>()
                {
                    StatusCode = (int)responce.StatusCode,
                    Value = JsonConvert.DeserializeObject<CoffeeForViewDTO>(await responce.Content.ReadAsStringAsync())
                };
            };
        }
    }
}
