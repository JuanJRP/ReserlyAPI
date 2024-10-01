namespace ReserlyAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public int ServiceId { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
    }
}
