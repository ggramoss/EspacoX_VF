
namespace EspacoX_V3.Models

{
    public class Admin
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DataAdmisao { get; set; }
        public string funcao { get; set; }
        public int BuildingId { get; set; }
        public Building building { get; set; }

    }

}
