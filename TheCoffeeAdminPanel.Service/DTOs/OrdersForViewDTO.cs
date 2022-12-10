namespace TheCoffeeAdminPanel.Service.DTOs
{
    public class OrdersForViewDTO
    {
        public int UserId { get; set; }
        public UserForViewDTO User { get; set; }
        public int CoffeeId { get; set; }
        public CoffeeForViewDTO Coffee { get; set; }
        public int AddressId { get; set; }
        public AddressForViewDTO Address { get; set; }
    }
}
