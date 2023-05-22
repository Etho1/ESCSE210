using System;
// How can I move prompts to used prompts after being used?
class Program
{
    static void Main(string[] args)
    {
        // Display a menu
        // Use a loop to show the menu

        // Options in the menu: 
        // * Display a random prompt
        // * New entry
        // * Select an entry
        // * Quit
        bool done = false;
        Prompt prompt = new Prompt();
        Journal journal = new Journal();
        do {
            // Display menu
            Console.WriteLine("Select an option:");
            Console.WriteLine("* [N]ew entry");
            Console.WriteLine("* [D]isplay all entries");
            Console.WriteLine("* [S]ave Entries to file");
            Console.WriteLine("* [L]oad Entries from file");
            Console.WriteLine("* [Q]uit");

            string input = Console.ReadLine();

            // Switch Case to handle input

            switch (input) {
                case "n" or "N":
                    // Store random prompt in variable
                    string currentPrompt = prompt.returnRandomPrompt();
                    //display current prompt
                    Console.WriteLine(currentPrompt);
                    //ask for user input
                    Console.Write("--> ");
                    string text = Console.ReadLine();
                    //send input and prompt to storage
                    Entry entry = new Entry(text,currentPrompt);
                    journal.CreateEntry(entry);
                    Console.WriteLine("Entry Saved!");
                    break;
                case "d" or "D":
                    journal.ShowEntries();
                    break;
                case "s" or "S":
                    Console.WriteLine("What is the name of the file you would like to save to?");
                    string userSaveFile = Console.ReadLine();
                    if (!File.Exists(userSaveFile)){
                    journal.SaveJournal(userSaveFile);
                    }
                    else {
                        journal.SaveJournal(userSaveFile);
                    }
                    Console.WriteLine("Journal saved!");
                    break;
                case "l" or "L":
                    Console.WriteLine("What is the name of the file you would like to load?");
                    string userLoadFile = Console.ReadLine();
                    if (File.Exists(userLoadFile)){
                    journal.LoadJournal(userLoadFile);}
                    else{
                        Console.WriteLine($"No such file exists ({userLoadFile})");
                    }
                    break;
                case "q" or "Q":
                    // When the user selects quit, change done to true to exit the loop
                    done = true;
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            // Display a prompt
            // Display 
        } while(!done);
    }
}