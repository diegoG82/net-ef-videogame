namespace net_ef_videogame.Models
{
    public class SoftwareHouse
    {
        public long SoftwareHouseId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }


        //RELAZIONE 1 A MOLTI: MOLTI VG X 1 SH
        public List<Videogame> Videogames { get; set; }
    }
}
