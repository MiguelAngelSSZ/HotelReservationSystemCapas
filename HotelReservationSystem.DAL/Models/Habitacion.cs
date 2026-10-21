using HotelReservationSystem.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Models
{
    public partial class Habitacion : AuditEntity
    {
        public int HabitacionId { get; set; }
        public int PisoId { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public decimal TarifaPorNoche { get; set; }
        public string EstadoOperativo { get; set; }
    }
}
