using HotelReservationSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Data
{
    public class HotelReservationDbContext : DbContext 
    {
        public HotelReservationDbContext(DbContextOptions<HotelReservationDbContext> options)
        : base(options)
        {

        }
        public DbSet<Hotel> Hoteles { get; set; }
        public DbSet<Piso> Pisos { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Huesped> Huespedes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
    }
}
