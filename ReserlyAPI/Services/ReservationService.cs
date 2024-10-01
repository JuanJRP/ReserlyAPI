namespace ReserlyAPI.Services
{
    using ReserlyAPI.Models;
    using ReserlyAPI.Repositories;
    // Services/ReservationService.cs
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<IEnumerable<Reservation>> GetAllReservations()
        {
            return await _reservationRepository.GetAllAsync();
        }

        public async Task<Reservation> GetReservationById(int id)
        {
            return await _reservationRepository.GetByIdAsync(id);
        }

        public async Task CreateReservation(Reservation reservation)
        {
            await _reservationRepository.AddAsync(reservation);
        }

        public async Task UpdateReservation(Reservation reservation)
        {
            await _reservationRepository.UpdateAsync(reservation);
        }

        public async Task CancelReservation(int id)
        {
            await _reservationRepository.DeleteAsync(id);
        }
    }

}
