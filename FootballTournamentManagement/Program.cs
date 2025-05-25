using System;
using System.Net;

namespace FootballTournamentManagement
{

    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome TO FootballTournament!");
            Console.WriteLine("Login");
            Console.WriteLine("Enter your userName :");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your code :");
            string codeString = Console.ReadLine();

            if (username == "hwary" && codeString == "1234")
            {
                Console.WriteLine("Login successful!");
                Console.WriteLine("Hii hwary ... you admin");
            }
            else
            {
                Console.WriteLine("Login failed! Please check your username and code.");
            }
            Console.WriteLine("Choose the answer:(1. Add a new team/2. View all teams/3.List of teem)");

            while (true)
            {
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Enter the team name:");
                        string teamName = Console.ReadLine();
                        Console.WriteLine($"Team {teamName} has been added successfully.");
                        break;
                    case "2":
                        string teams = " hwaryFc, Alahly Fc, RealMadridFc";
                        Console.WriteLine($"all teams... {teams}:");
                        break;
                    case "3":
                        Console.WriteLine("Enter the team name:");
                        string teamList = Console.ReadLine();
                        switch (teamList)
                        {
                            case "RealMadrid":
                                Console.WriteLine("Real Madrid list is:\r\nGoalkeepers\r\n- Thibaut Courtois\r\n- Andriy Lunin\r\n- Fran González\r\nDefenders\r\n- Dani Carvajal\r\n- Éder Militão\r\n- David Alaba\r\n- Antonio Rüdiger\r\n- Ferland Mendy\r\n- Fran García\r\n- Jesús Vallejo\r\n- Lucas Vázquez\r\nMidfielders\r\n- Jude Bellingham\r\n- Eduardo Camavinga\r\n- Federico Valverde\r\n- Luka Modrić\r\n- Aurélien Tchouaméni\r\n- Arda Güler\r\n- Dani Ceballos\r\n- Brahim Díaz\r\nForwards\r\n- Vinícius Júnior\r\n- Kylian Mbappé\r\n- Rodrygo\r\n- Endrick\r\n   .");
                                break;

                            case "hwaryFc":

                                Console.WriteLine("Hwary FC list is:\r\nGoalkeepers\r\n- Thibaut Courtois\r\n- Andriy Lunin\r\n- Fran González\r\nDefenders\r\n- m.hwary\r\n- Ossama \r\n- EL zogby\r\n- Ferland Mendy\r\n- Fran García\r\n- Jesús Vallejo\r\n- Lucas Vázquez\r\nMidfielders \r\n- bebo\r\n- Nashaat\r\n- Eid hwary\r\nForwards\r\n- Abd elrahman\r\n- Ahmed adel\r\n- Ahmed atef\r\n- Mohamed yasser\r\n.");
                                break;

                            case "Alahly Fc":

                                Console.WriteLine("Al Ahly FC is one of the most successful clubs in Africa.");
                                break;

                            case "":

                                Console.WriteLine("Team not found.");
                                break;
                        }

                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please select 1, 2, or 3.");
                        break;
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                string continueChoice = Console.ReadLine();
                if (continueChoice.ToLower() != "y")
                {
                    break;
                }
            }
            
        }
    }
}

