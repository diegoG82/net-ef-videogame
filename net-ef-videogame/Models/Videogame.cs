namespace net_ef_videogame.Models
{
    public class Videogame
    {
        public long VideogameId { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public DateTime ReleaseDate { get; set; }

        //RELAZIONE MOLTI AD 1 UNA SH PER MOLTI VG 

        public long SoftwareHouseId { get; set; }    
        public SoftwareHouse SoftwareHouse { get; set; }


        public override string ToString()
        {
            return $"{VideogameId}: {Name} {Overview} - {ReleaseDate}";
        }

    }
}
