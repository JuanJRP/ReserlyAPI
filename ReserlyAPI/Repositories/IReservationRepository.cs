namespace ReserlyAPI.Repositories
{
    using ReserlyAPI.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IReservationRepository
    {
        Task<Reservation> GetByIdAsync(int id);
        Task<IEnumerable<Reservation>> GetAllAsync();
        Task AddAsync(Reservation reservation);
        Task UpdateAsync(Reservation reservation);
        Task DeleteAsync(int id);
    }
}
