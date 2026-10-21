using HotelReservationSystem.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Models
{
    public partial class Reserva : AuditEntity
    {
        public int ReservaId { get; set; }
        public int HuespedId { get; set; }
        public int HabitacionId { get; set; }
        public DateTime FechaEntrada { get; set; }
        public DateTime FechaSalida { get; set; }
        public int CantidadHuespedes { get; set; }
        public string Estado { get; set; }
        public decimal CostoTotal { get; set; }
    }
}
