using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Repositories
{
    public interface IPisoRepository
    {
        Task<List<Piso>> GetAllAsync();
        Task<Piso?> GetByIdAsync(int id);
        Task AddAsync(Piso piso);
        Task UpdateAsync(Piso piso);
        Task DeleteAsync(Piso piso);
    }
}
