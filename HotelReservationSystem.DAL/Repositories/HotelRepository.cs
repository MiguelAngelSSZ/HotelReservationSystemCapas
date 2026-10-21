using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.DAL.Data;
using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Repositories
{
    public class HotelRepository(HotelReservationDbContext context) : IHotelRepository
    {
        public Task<List<Hotel>> GetAllAsync() => context.Hoteles.AsNoTracking().OrderBy(x => x.Nombre).ToListAsync();
        public Task<Hotel?> GetByIdAsync(int id) => context.Hoteles.FirstOrDefaultAsync(x => x.HotelId == id);
        public async Task AddAsync(Hotel hotel) { context.Hoteles.Add(hotel); await context.SaveChangesAsync(); }
        public async Task UpdateAsync(Hotel hotel) { await context.SaveChangesAsync(); }
        public async Task DeleteAsync(Hotel hotel) { context.Hoteles.Remove(hotel); await context.SaveChangesAsync(); }
    
    }
}
