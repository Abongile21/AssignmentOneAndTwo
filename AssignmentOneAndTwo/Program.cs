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
                int number;

                if(int.TryParse(songLength, out number)){
                    beerSong.singBeerSong(int.Parse(songLength));

                }
                else{
                    Console.WriteLine("Enter a number!");
                }
                

                //Do something
            }
            else if (int.Parse(choice) == 2) {

                //Play 
                GuessTheNumber guessTheNumber = new GuessTheNumber();
                guessTheNumber.Play();

            }
            else
            {
                Console.WriteLine("Game not available at moment");
            }


        }
    }
}
