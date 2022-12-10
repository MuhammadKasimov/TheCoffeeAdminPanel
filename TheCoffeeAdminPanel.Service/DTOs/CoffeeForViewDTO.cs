using System;

namespace TheCoffeeAdminPanel.Service.DTOs
{
    public class CoffeeForViewDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public int AttachmentId { get; set; }
        public AttachmentForViewDTO Attachment { get; set; }
    }
}
