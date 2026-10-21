using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.DAL.Data;
using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Repositories
{
    public class HuespedRepository(HotelReservationDbContext context) : IHuespedRepository
    {
        public Task<List<Huesped>> GetAllAsync() => context.Huespedes.AsNoTracking().OrderBy(x => x.Nombre).ToListAsync();
        public Task<Huesped?> GetByIdAsync(int id) => context.Huespedes.FirstOrDefaultAsync(x => x.HuespedId == id);
        public async Task AddAsync(Huesped huesped) { context.Huespedes.Add(huesped); await context.SaveChangesAsync(); }
        public async Task UpdateAsync(Huesped huesped) { await context.SaveChangesAsync(); }
        public async Task DeleteAsync(Huesped huesped) { context.Huespedes.Remove(huesped); await context.SaveChangesAsync(); }
    }
}
