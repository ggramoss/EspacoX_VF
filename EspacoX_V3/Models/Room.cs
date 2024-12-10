using System;

namespace EspacoX_V3.Models
{
  

    public class Room
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Capacidade { get; set; }
 
        public string? Descrição { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
        

    }   
}
