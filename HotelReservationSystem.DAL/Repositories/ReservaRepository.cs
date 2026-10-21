using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.DAL.Data;
using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Repositories
{
    public class ReservaRepository(HotelReservationDbContext context) : IReservaRepository
    {
        public Task<List<Reserva>> GetAllAsync() => context.Reservas.AsNoTracking().OrderByDescending(x => x.FechaEntrada).ToListAsync();
        public Task<Reserva?> GetByIdAsync(int id) => context.Reservas.FirstOrDefaultAsync(x => x.ReservaId == id);
        public async Task AddAsync(Reserva reserva) { context.Reservas.Add(reserva); await context.SaveChangesAsync(); }
        public async Task UpdateAsync(Reserva reserva) { await context.SaveChangesAsync(); }
        public async Task DeleteAsync(Reserva reserva) { context.Reservas.Remove(reserva); await context.SaveChangesAsync(); }
    }
}
