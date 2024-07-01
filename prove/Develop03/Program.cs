class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        string text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();

            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("All words are hidden. Goodbye!");
                break;
            }
        }
    }
}
