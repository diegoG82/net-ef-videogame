using net_ef_videogame.Database;
using net_ef_videogame.Models;

namespace net_ef_videogame
{
    internal class VideogameManager
    {


        // CREATE VIDEOGAME METHOD
        public void CreateVideogame(string name, string overview, DateTime releasedate, long softwareHouseId)
        {
            Videogame newVideogame = new Videogame()
            {
                Name = name,
                Overview = overview,
                ReleaseDate = releasedate,
                SoftwareHouseId = softwareHouseId
            };

            using (VideoGameContext db = new VideoGameContext())
            {
                try
                {
                    db.Add(newVideogame);
                    db.SaveChanges();

                    Console.WriteLine("Game Added!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void CreateSoftwareHouse(string name, string country)
        {
            SoftwareHouse newSoftwareHouse = new SoftwareHouse()
            {
                Name = name,
                Country = country,

            };

            using (VideoGameContext db = new VideoGameContext())
            {
                try
                {
                    db.Add(newSoftwareHouse);
                    db.SaveChanges();

                    Console.WriteLine("Software House Added!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void FilterGameById(long videogameIdToFind)
        {
            try
            {

                Console.WriteLine("Search game by id:");

                using (VideoGameContext db = new VideoGameContext())
                {
                    List<Videogame> filteredVideogames = db.Videogames.Where(v => v.VideogameId == videogameIdToFind).ToList();

                    foreach (Videogame v in filteredVideogames)
                    {
                        Console.WriteLine("- " + v);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void FilterByString(string videogametofind)
        {
            try
            {
                Console.WriteLine("Search game by string:");

                using (VideoGameContext db = new VideoGameContext())
                {
                    List<Videogame> filteredVideogames = db.Videogames.Where(v => v.Name.Contains(videogametofind)).ToList();

                    foreach (Videogame v in filteredVideogames)
                    {
                        Console.WriteLine("- " + v);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }

        public void DeleteVideogame(long gameToDelete)
        {
            try
            {
                using (VideoGameContext db = new VideoGameContext())
                {
                    Videogame Videogame = db.Videogames.Where(Videogame => Videogame.VideogameId == gameToDelete).First();
                    db.Videogames.Remove(Videogame);
                    db.SaveChanges();
                    Console.WriteLine("Videogame deleted");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
        }

        public void ListGameBySoftwareHouse(long softwareHouseId)
        {
            using (VideoGameContext db = new VideoGameContext())
            {

                List<Tuple<string, string>> videogamesBySoftwareHouse = db.Videogames
                                    .Where(v => v.SoftwareHouse.SoftwareHouseId == softwareHouseId)
                                    .Select(v => new Tuple<string, string>(v.Name, v.SoftwareHouse.Name))
                                    .ToList();

                foreach (var videogamelisted in videogamesBySoftwareHouse)
                {
                    Console.WriteLine($"Here are the {videogamelisted.Item2} games:");
                    Console.WriteLine();
                    Console.WriteLine(videogamelisted.Item1);
                }
            }
        }




    }


}





