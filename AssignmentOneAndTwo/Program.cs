namespace AssignmentOneAndTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "********************************************\n" +
                "*           Welcome to my games!           *\n" +
                "********************************************");

            Console.WriteLine();


            Console.WriteLine("*** Pick game to play ***");
            Console.WriteLine(" 1.Beer Song.");
            Console.WriteLine(" 2.Numbers guess game.");
            
            string choice = Console.ReadLine();

            if (int.Parse(choice) == 1)
            {
                Console.WriteLine("Enter the length of your song:");
                string songLength = Console.ReadLine();
                BeerSong beerSong = new BeerSong();
                beerSong.singBeerSong(int.Parse(songLength));

                //Do something
            }
            else if (int.Parse(choice) == 2) {

                //Do something
                GuessTheGame game = new GuessTheGame();
                game.Play();



            }
            else
            {
                Console.WriteLine("Game not available at moment");
            }


        }
    }
}
