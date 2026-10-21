using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.DAL.Data;
using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Repositories
{
    public class HabitacionRepository(HotelReservationDbContext context) : IHabitacionRepository
    {
        public Task<List<Habitacion>> GetAllAsync() => context.Habitaciones.AsNoTracking().OrderBy(x => x.Numero).ToListAsync();
        public Task<Habitacion?> GetByIdAsync(int id) => context.Habitaciones.FirstOrDefaultAsync(x => x.HabitacionId == id);
        public async Task AddAsync(Habitacion habitacion) { context.Habitaciones.Add(habitacion); await context.SaveChangesAsync(); }
        public async Task UpdateAsync(Habitacion habitacion) { await context.SaveChangesAsync(); }
        public async Task DeleteAsync(Habitacion habitacion) { context.Habitaciones.Remove(habitacion); await context.SaveChangesAsync(); }
    }
}
