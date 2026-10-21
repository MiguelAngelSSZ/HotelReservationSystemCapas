using HotelReservationSystem.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem.DAL.Models
{
    public partial class Piso : AuditEntity
    {
        public int PisoId { get; set; }
        public int HotelId { get; set; }
        public int NumeroPiso { get; set; }
        public bool Estado { get; set; }


    }
}
