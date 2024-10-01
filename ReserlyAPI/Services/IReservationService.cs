namespace ReserlyAPI.Services
{
    using ReserlyAPI.Models;
    // Services/IReservationService.cs
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IReservationService
    {
        Task<IEnumerable<Reservation>> GetAllReservations();
        Task<Reservation> GetReservationById(int id);
        Task CreateReservation(Reservation reservation);
        Task UpdateReservation(Reservation reservation);
        Task CancelReservation(int id);
    }
}
