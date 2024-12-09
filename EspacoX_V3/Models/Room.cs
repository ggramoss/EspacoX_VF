using System;

namespace EspacoX_V3.Models
{
  

    public class Room
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Capacity { get; set; }
        public bool? Availability { get; set; }
        public string? Description { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

    }   
}
