using System;
using System.ComponentModel.DataAnnotations;

namespace EspacoX_V3.Models
{


    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }

    }

}
