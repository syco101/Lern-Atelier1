
using System.ComponentModel.Design;
using System.Net.Security;
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("By syco101");
    DateTime currentTimeUtc = DateTime.Now;
    Console.WriteLine(currentTimeUtc);
}
{
    double Number1 = 0;
    double Number2 = 0;
    string Operation;
    double Result = 0;

    Console.WriteLine("----------------------");
    Console.WriteLine("|                    |");
    Console.WriteLine("|Der Taschenreechner!|");
    Console.WriteLine("|                    |");
    Console.WriteLine("|                    |");
    Console.WriteLine("----------------------");

    string userWantsToContinue = "ja";
    while (userWantsToContinue == "ja")
        
    {



        {
            try

            {
                Console.WriteLine("Gebe die erste Zahl ein");
                Number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gebe die zweite Zahl ein");
                Number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gebe eine Operation ein  +  -  x  /");
                Operation = Console.ReadLine();
                {
                    switch (Operation)
                    {
                        case "+":
                            Result = Number1 + Number2;
                            Console.WriteLine($"Result:  {Result}");
                            break;

                        case "-":
                            Result = Number1 - Number2;
                            Console.WriteLine($"Result: {Result}");
                            break;

                        case "x":

                            Result = Number1 * Number2;
                            Console.WriteLine($"Result:  {Result}");
                            break;


                        case "/":
                            if (Number2 != 0)
                            {
                                Result = Number1 / Number2;
                                Console.WriteLine($"Ergebnis: {Result}");
                            }
                            else
                            {
                                Console.WriteLine("Divsion ist mit 0 nicht möglich.");
                            }

                            break;
                        default:
                            Console.WriteLine("Diese Operation ist nicht möglich.");

                            Console.WriteLine("Möchten Sie eine weitere Berechnung durchführen? (ja/nein)");
                            userWantsToContinue = Console.ReadLine();
                            break;


                    }
                }
            

            Console.WriteLine("Möchten Sie eine weitere Berechnung durchführen? (ja/nein)");
            userWantsToContinue = Console.ReadLine();
        }
        
            catch
            {
                Console.WriteLine("keine Buchstaben erlaubt");
                {

                }

            }
        }
    }




    Console.WriteLine("Danke das sie mich eingesetzt haben :)");
    Console.WriteLine("Ciao miao");
}
