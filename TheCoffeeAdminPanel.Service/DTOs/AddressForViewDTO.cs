using System;

namespace TheCoffeeAdminPanel.Service.DTOs
{
    public class AddressForViewDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string City { get; set; }
        public string FullAddres { get; set; }
    }
}
