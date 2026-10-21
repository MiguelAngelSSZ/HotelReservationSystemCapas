using HotelReservationSystem.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Models
{
    public partial class Huesped : AuditEntity
    {
        public int HuespedId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DocumentoIdentidad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
