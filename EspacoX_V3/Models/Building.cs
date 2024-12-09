using System.Collections.Generic;

namespace EspacoX_V3.Models
{
    

    public class Building
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();

        
    }

}
