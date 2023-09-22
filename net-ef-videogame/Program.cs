﻿using net_ef_videogame.Database;
using net_ef_videogame.Models;

namespace net_ef_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our Videogames manager!!!");


            while (true)
            {
                Console.WriteLine(@"
- 1: Create VideoGames 
- 2  Create SoftwareHouse   
- 3: Show VideoGames by Id
- 4: Search Videogames by String
- 5: Delete VideoGames
- 6: Exit 

");

                Console.Write("Make your choice: ");

                int selectedOption = int.Parse(Console.ReadLine());

                switch (selectedOption)
                {
                    //CREATE A VIDEOGAME
                    case 1:
                        {
                            Console.WriteLine("Create a Videogame:");
                            Console.WriteLine("Enter the title of the game: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the overview of the game: ");
                            string overview = Console.ReadLine();
                            Console.WriteLine("Enter the release date of the game: ");
                            DateTime releasedate = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the software house ID of the game: ");
                            long softwareHouseId = long.Parse(Console.ReadLine());

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

                            break;

                        }

                    //CREATE A SOFTWARE HOUSE
                    case 2:

                        Console.WriteLine("Create a Software House:");
                        {

                            Console.WriteLine("Enter the name of the software house: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the country of the software house: ");
                            string country = Console.ReadLine();


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
                            break;
                        }




                    //FILTER BY ID
                    case 3:
                        try
                        {
                            Console.WriteLine("Search game by id:");
                            Console.WriteLine("Insert Videogame ID");
                            long videogameIdToFind = long.Parse(Console.ReadLine());

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


                        break;

                    //FILTER BY STRING

                    case 4:
                        try
                        {
                            Console.WriteLine("Search game by string:");
                            Console.WriteLine("write something");
                            string videogametofind = Console.ReadLine();

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

                        break;

                    //DELETE
                    case 5:

                        Console.WriteLine("Insert The game Id you want to delete");
                        long gameToDelete = long.Parse(Console.ReadLine());

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
                        break;

                    case 6:
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("No options choosed");
                        break;
                }
            }
        }
    }
}
