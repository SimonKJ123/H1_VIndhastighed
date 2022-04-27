
static void Main(string[] args)
{
    Console.ForegroundColor = ConsoleColor.White;
    string menu = "";

    Console.SetCursorPosition(20, 2);
    Console.WriteLine("Hovedemenu");
    Console.SetCursorPosition(20, 3);
    Console.WriteLine("--------------------------------");
    Console.SetCursorPosition(20, 4);
    Console.WriteLine("Tryk 1 For Konvertere km/t");
    Console.SetCursorPosition(20, 5);
    Console.WriteLine("Tryk 2 For Konvertere knots");
    Console.SetCursorPosition(20, 6);
    Console.WriteLine("Tryk 3 For Konvertere mph");
    Console.SetCursorPosition(20, 7);
    Console.WriteLine("Tryk 4 For Konvertere m/s");
    Console.ReadKey();

    switch (menu)
    {

        case "1":
            {
                Console.WriteLine("Indtast km/t");
                int kmtt = Convert.ToInt32(Console.ReadLine());
            }
            break;
        case "2":
            {
                Console.WriteLine("Knovertering Complete");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            break;
        case "3":
            {
                Console.WriteLine("Knovertering Complete");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            break;
        case "4":
            {
                Console.WriteLine("Knovertering Complete");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            break;

    }

}
