using System;

namespace TheCoffeeAdminPanel.Service.DTOs
{
    public class AttachmentForViewDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}
