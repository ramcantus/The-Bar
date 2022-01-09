// Console
Console.ForegroundColor = ConsoleColor.White;
Console.Title = "The Bar";
 // Code
Console.Write("Press 1 and then enter to play :3:");
int num1 = 0;
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Welcome to the bar! (To play this game youll need to type 1,2 or 3 for the options!)");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.ReadLine();
Console.WriteLine("Choose wherever you wanna sit, we have a seat at the bar, one at the back, and one at the window wich one do you want?");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Option 1. Bar");
Console.WriteLine("Option 2. Back");
Console.WriteLine("Option 3. Window");
Console.ResetColor();
Console.Write("Your option? ");
Console.ForegroundColor = ConsoleColor.Magenta;
switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Good choice. I'll see you at the bar.");
            break;
        case "2":
            Console.WriteLine("Good choice. I'll see you at the back.");
            break;
        case "3":
            Console.WriteLine("Good choice. I'll see you at the window.");
            break;
    }
Console.WriteLine("Okay you're all set. \n Something to drink? Let me give you the options");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Option 1. Beer");
Console.WriteLine("Option 2. Water");
Console.WriteLine("Option 3. Soda");
Console.ResetColor();
Console.Write("Your option? ");
Console.ForegroundColor = ConsoleColor.Magenta;
switch (Console.ReadLine())
{
        case "1":
            Console.WriteLine("Good choice. We have the best beer in the world here.");
            break;
        case "2":
            Console.WriteLine("Pussy who chooses water in a bar :v.");
            break;
        case "3":
            Console.WriteLine("Good choice. The best of the bests in my opinion.");
            break;
    }

Console.WriteLine("I'll be back in 5 minutes.");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("*5 minutes passes*");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("K i'm back with your drink. \n Something to eat?");
Console.ReadLine();
Console.WriteLine("Here are all the options.");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Option 1. Steak");
Console.WriteLine("Option 2. Salad");
Console.WriteLine("Option 3. Chicken");
Console.ResetColor();
Console.Write("Your option? ");
Console.ForegroundColor = ConsoleColor.Magenta;
switch (Console.ReadLine())
{
        case "1":
            Console.WriteLine("This is the house favorite, You'll love it.");
            break;
        case "2":
            Console.WriteLine("REALLY BITCH!! A SALAD??.");
            break;
        case "3":
            Console.WriteLine("My personal favorite.");
            break;
    }
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("THE END");
Console.WriteLine("Press enter to leave");
Console.ReadKey();
 //Finish
