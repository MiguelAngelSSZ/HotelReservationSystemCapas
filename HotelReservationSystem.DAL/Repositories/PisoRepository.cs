using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.DAL.Data;
using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Repositories
{
    public class PisoRepository(HotelReservationDbContext context) : IPisoRepository
    {
        public Task<List<Piso>> GetAllAsync() => context.Pisos.AsNoTracking().OrderBy(x => x.NumeroPiso).ToListAsync();
        public Task<Piso?> GetByIdAsync(int id) => context.Pisos.FirstOrDefaultAsync(x => x.PisoId == id);
        public async Task AddAsync(Piso piso) { context.Pisos.Add(piso); await context.SaveChangesAsync(); }
        public async Task UpdateAsync(Piso piso) { await context.SaveChangesAsync(); }
        public async Task DeleteAsync(Piso piso) { context.Pisos.Remove(piso); await context.SaveChangesAsync(); }
    }
}
