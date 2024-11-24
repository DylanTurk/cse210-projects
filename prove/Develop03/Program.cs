using System;

class Program
{
    static void Main(string[] args)
    {
        // Example reference and scripture
        string reference = "John 3:16";
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // Create a Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);
        
        bool quit = false;
        while (!quit)
        {
            Console.Clear();  // Clear the console for each loop iteration
            scripture.DisplayScripture();  // Display the scripture with hidden words if any
            
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                quit = true;  // Exit the loop if 'quit' is typed
            }
            else
            {
                scripture.HideRandomWords();  // Hide a random word if Enter is pressed
                
                // Check if all words are hidden and end the program if true
                if (scripture.AllWordsHidden())
                {
                    Console.Clear();
                    scripture.DisplayScripture();  // Display final scripture with all words hidden
                    Console.WriteLine("All words are hidden. The program has ended.");
                    quit = true;  // Exit the program
                }
            }
        }
    }
}