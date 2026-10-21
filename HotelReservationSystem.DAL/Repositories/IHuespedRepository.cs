using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Repositories
{
    public interface IHuespedRepository
    {
        Task<List<Huesped>> GetAllAsync();
        Task<Huesped?> GetByIdAsync(int id);
        Task AddAsync(Huesped huesped);
        Task UpdateAsync(Huesped huesped);
        Task DeleteAsync(Huesped huesped);
    }
}
