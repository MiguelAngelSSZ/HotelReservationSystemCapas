using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.DAL.Data;
using HotelReservationSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Repositories
{
    public class NotificacionRepository(HotelReservationDbContext context) : INotificacionRepository
    {
        public Task<List<Notificacion>> GetAllAsync() => context.Notificaciones.AsNoTracking().OrderByDescending(x => x.FechaEnvio).ToListAsync();
        public Task<Notificacion?> GetByIdAsync(int id) => context.Notificaciones.FirstOrDefaultAsync(x => x.NotificacionId == id);
        public async Task AddAsync(Notificacion notificacion) { context.Notificaciones.Add(notificacion); await context.SaveChangesAsync(); }
        public async Task UpdateAsync(Notificacion notificacion) { await context.SaveChangesAsync(); }
        public async Task DeleteAsync(Notificacion notificacion) { context.Notificaciones.Remove(notificacion); await context.SaveChangesAsync(); }
    }
}
