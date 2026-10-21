using HotelReservationSystem.DAL.Models;
using HotelReservationSystem.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.BL.Services;

public class HotelService : IHotelService
{
    public Task CreateAsync(Hotel hotel)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Hotel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Hotel?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Hotel hotel)
    {
        throw new NotImplementedException();
    }
}
