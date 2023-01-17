namespace InheritanceOfAnimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bird bird;
            Console.WriteLine("\nPress P for pidgeon, O for ostrich: ");
            char key = Console.ReadKey(true).KeyChar;
            if (key == 'P') bird = new Pidgeon();
            else if (key == 'O') bird = new Ostrich();
            else return;
            Console.WriteLine("\nHow many eggs should it lay? ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
            Egg[] eggs = bird.LayEggs(numberOfEggs);
            foreach (Egg egg in eggs)
            {
                Console.WriteLine(egg.Description);
            }

        }
    }
}