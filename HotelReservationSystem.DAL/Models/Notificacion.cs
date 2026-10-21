using HotelReservationSystem.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Models
{
    public partial class Notificacion : AuditEntity
    {
        public int NotificacionId { get; set; }
        public int ReservaId { get; set; }
        public int HuespedId { get; set; }
        public string TipoNotificacion { get; set; }
        public DateTime FechaEnvio { get; set; }
        public bool EstadoEnvio { get; set; }
        public string Mensaje { get; set; }
    }
}
