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

                        }
                        break;


                    //CREATE A SOFTWARE HOUSE
                    case 2:

                        Console.WriteLine("Create a Software House:");


                        break;

                    //FILTER BY ID
                    case 3:

                        Console.WriteLine("Insert Game Id:");


                        break;
                    //FILTER BY STRING
                    case 4:
                        {


                            return;
                        }

                    case 5:
                        Console.Write("Insert the Game Id you want to delete: ");

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