using CrypticWizard.RandomWordGenerator;

bool playagain = false;
WordGenerator wg = new WordGenerator();
do
{

    Console.Clear();
    Console.WriteLine("                                                                           \r\n                                                                           \r\n██  ██  ▄▄▄  ▄▄  ▄▄  ▄▄▄▄ ▄▄   ▄▄  ▄▄▄  ▄▄  ▄▄    ▄▄▄▄  ▄▄▄  ▄▄   ▄▄ ▄▄▄▄▄ \r\n██████ ██▀██ ███▄██ ██ ▄▄ ██▀▄▀██ ██▀██ ███▄██   ██ ▄▄ ██▀██ ██▀▄▀██ ██▄▄  \r\n██  ██ ██▀██ ██ ▀██ ▀███▀ ██   ██ ██▀██ ██ ▀██   ▀███▀ ██▀██ ██   ██ ██▄▄▄ \r\n                                                                           ");
    Console.WriteLine("  _           ___            _      _ _     _____ \r\n | |__ _  _  |   \\ ___ _ __ (_)_ _ (_) |__ |_   _|\r\n | '_ \\ || | | |) / _ \\ '  \\| | ' \\| | / /   | |_ \r\n |_.__/\\_, | |___/\\___/_|_|_|_|_||_|_|_\\_\\   |_(_)\r\n       |__/                                       ");
    Console.WriteLine("\n\n\nPick an option (1 or 2): ");
    Console.WriteLine("1. Enter a custom word (hidden): ");
    Console.WriteLine("2. Generate a random word: ");

    string izbor = Console.ReadLine();
    string word = "";

    if (izbor == "1")
    {
        Console.WriteLine("\nEnter you word (hidden): ");
        word = HideWord();

    }
    else
    {
       
        word = wg.GetWord(WordGenerator.PartOfSpeech.noun).ToLower();
        Console.WriteLine("Random word generated!");


    }

    int maxZivoti = 7;
    int zivoti = maxZivoti;
    bool win = false;
    List<char> letters = new List<char>();

    while (zivoti > 0 && !win)
    {

        Console.Clear();
        DrawHangman(zivoti, maxZivoti);

        foreach (char c in word)
        {
            if (letters.Contains(c)) Console.Write($"{c} ");
            else Console.Write("_ ");
        }

        Console.WriteLine("\n\n");
        Console.Write("Guessed letters: ");
        if (letters.Count > 0)
        {
            Console.WriteLine(string.Join(", ", letters));

        }
        else
        {
            Console.WriteLine("none");
        }
        Console.WriteLine($"{zivoti}/{maxZivoti} lives remaining.");
        Console.WriteLine("\n───────────────────────────────");
        Console.Write("\n> Guess a letter: ");


        string input = Console.ReadLine();
        while (input.Length != 1)
        {
            Console.Write("Please type a single letter: ");
            input = Console.ReadLine();


        }
        char guess = input[0];


        if (!word.Contains(guess))
        {
            zivoti--;
        }
        if (!letters.Contains(guess))
            letters.Add(guess);


        bool WinCheck = true;     //odma pretpostavi da je sve tocno ali cim                  
        foreach (char c in word)  //nade neko krivo slovo odma se prebacuje u false
        {
            if (!letters.Contains(c)) WinCheck = false;

        }
        win = WinCheck;
    }


        Console.Clear();
        if (win)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("__  ______  __  __   _       _______   __\r\n\\ \\/ / __ \\/ / / /  | |     / /  _/ | / /\r\n \\  / / / / / / /   | | /| / // //  |/ / \r\n / / /_/ / /_/ /    | |/ |/ // // /|  /  \r\n/_/\\____/\\____/     |__/|__/___/_/ |_/   \r\n                                         ");
            Console.WriteLine("=========================================");
            Console.WriteLine($"\n\nthe word was: {word}");

        }
        else
        {
            DrawHangman(1, maxZivoti);
            Console.WriteLine("\n\n__  ______  __  __   __    ____  ___________\r\n\\ \\/ / __ \\/ / / /  / /   / __ \\/ ___/_  __/\r\n \\  / / / / / / /  / /   / / / /\\__ \\ / /   \r\n / / /_/ / /_/ /  / /___/ /_/ /___/ // /    \r\n/_/\\____/\\____/  /_____/\\____//____//_/     \r\n                                            ");
            Console.WriteLine($"the word was: {word}");
        }

        Console.WriteLine("> Play again? (y/n): ");
        if(Console.ReadLine().ToLower()=="y")playagain=true;
        else playagain =false;

    
    
    void DrawHangman(int zivoti2, int maxZivoti2)
    {
        int wrongguess=maxZivoti2 - zivoti2;

        string[] stages = new string[]
        {
        "  +---+\n  |   |\n      |\n      |\n      |\n      |\n=========",
        "  +---+\n  |   |\n  O   |\n      |\n      |\n      |\n=========",
        "  +---+\n  |   |\n  O   |\n  |   |\n      |\n      |\n=========",
        "  +---+\n  |   |\n  O   |\n /|   |\n      |\n      |\n=========",
        "  +---+\n  |   |\n  O   |\n /|\\  |\n      |\n      |\n=========",
        "  +---+\n  |   |\n  O   |\n /|\\  |\n /    |\n      |\n=========",
        "  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |\n========="
        };
        Console.WriteLine(stages[wrongguess]);
        //npr max zivoti 7-7=0 ispisat će prvi stage 

    }
    string HideWord()
    {
        string rezultat = "";
        ConsoleKeyInfo znak;

        do
        {
            znak = Console.ReadKey(intercept: true);
            //ucita jedan char bez da ga ispiše
            if (znak.Key == ConsoleKey.Backspace && rezultat.Length > 0)
            {
                rezultat=rezultat.Substring(0, rezultat.Length - 1); 
                Console.Write("\b \b");
                //ako pritisne backspace onda se pomakne unazad za 1 i ispiše razmak pa opet unazad za 1
            }
            else if (znak.Key != ConsoleKey.Enter && znak.Key != ConsoleKey.Backspace)
            {                                                                                       
                rezultat += znak.KeyChar;
                Console.Write("*");
            }
        }
        while (znak.Key!=ConsoleKey.Enter);
        Console.WriteLine();
        return rezultat.ToLower();
    }

}
while (playagain);