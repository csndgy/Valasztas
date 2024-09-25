namespace ValasztasWebApp.Models
{
    public class Jelolt
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int Kerulet { get; set; }
        public int Szavazatok { get; set; }
        public Part Part { get; set; }
    }
}
