using System.Collections.Generic;

namespace EspacoX_V3.Models
{
    

    public class Building
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public string Cidade { get; set; }
        public string Estado { get; set; }
        
        public List<Room> Rooms { get; set; } = new List<Room>();

        
    }

}
