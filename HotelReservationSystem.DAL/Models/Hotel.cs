using HotelReservationSystem.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Models
{
    public partial class Hotel : AuditEntity
    {
        public int HotelId { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }

    }
}
