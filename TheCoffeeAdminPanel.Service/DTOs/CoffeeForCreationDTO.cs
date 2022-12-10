using System.IO;

namespace TheCoffeeAdminPanel.Service.DTOs
{
    public class CoffeeForCreationDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public Stream Image { get; set; }
    }
}
