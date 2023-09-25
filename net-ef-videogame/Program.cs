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
- 7 Bonus

");

                Console.Write("Make your choice: ");

                int selectedOption = int.Parse(Console.ReadLine());

                VideogameManager videogame = new VideogameManager();


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

                            videogame.CreateVideogame(name, overview, releasedate, softwareHouseId);
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

                            videogame.CreateSoftwareHouse(name, country);

                            break;
                        }

                    //FILTER BY ID
                    case 3:

                        Console.WriteLine("Insert Videogame ID");
                        long videogameIdToFind = long.Parse(Console.ReadLine());
                        videogame.FilterGameById(videogameIdToFind);

                        break;

                    //FILTER BY STRING

                    case 4:

                        Console.WriteLine("write something");
                        string videogametofind = Console.ReadLine();
                        videogame.FilterByString(videogametofind);

                        break;

                    //DELETE
                    case 5:

                        Console.WriteLine("Insert The game Id you want to delete");
                        long gameToDelete = long.Parse(Console.ReadLine());
                        videogame.DeleteVideogame(gameToDelete);


                        break;

                    case 6:
                        Console.WriteLine("Exiting the program...");
                        return;

                    case 7:

                        Console.WriteLine("Insert the Id of the Software House : ");
                        long ShId = long.Parse(Console.ReadLine());
                        videogame.ListGameBySoftwareHouse(ShId);

                        return;

                    default:
                        Console.WriteLine("No options choosed");
                        break;
                }
            }
        }
    }
}
