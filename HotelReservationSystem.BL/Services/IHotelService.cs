using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.BL.Services;

public interface IHotelService
{
    Task<List<Hotel>> GetAllAsync();
    Task<Hotel?> GetByIdAsync(int id);
    Task CreateAsync(Hotel hotel);
    Task UpdateAsync(Hotel hotel);
    Task DeleteAsync(int id);
}
