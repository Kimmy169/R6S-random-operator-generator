namespace Rainbow_6_Siege_random_operator_generator
{
    using System;
    using System.Security.Cryptography.X509Certificates;

    /// <summary>
    /// Start app.
    /// </summary>
    public class App
    {
        /// <summary>
        /// Main.
        /// </summary>
        /// <param name="args">Console arguments.</param>
        public static void Main(string[] args)
        {
            int pick = 0;
            string side = "X";

            string[] attackers = new string[34] { "Sledge", "Thatcher", "Ash", "Thermite", "Montagne", "Twitch", "Blitz", "IQ", "Fuze", "Glaz", "Buck", "Blackbeard", "Capitao", "Hibana", "Jackal", "Ying", "Zofia", "Dokkaebi", "Finka", "Lion", "Maverick", "Nomad", "Gridlock", "Nokk", "Amaru", "Kali", "Iana", "Ace", "Zero", "Flores", "Osa", "Sense", "Grim","Brava" };

            string[] defenders = new string[33] { "Smoke", "Mute", "Castle", "Pulse", "Rook", "Doc", "Bandit", "Jäger", "Kapkan", "Tachanka", "Frost", "Valkyrie", "Caveira", "Echo", "Mira", "Lesion", "Ela", "Vigil", "Maestro", "Alibi", "Clash", "Kaid", "Mozzie", "Warden", "Goyo", "Wamai", "Oryx", "Melusi", "Aruni", "Thunderbird", "Thorn", "Azami", "Solis","Fenrir" };

            Console.Write("Input your nickname: ");
            string nickname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nHello " + nickname);

            while (side != "e" || side != "E") {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nChoose side (A: for attakcer | D: for defender) and E for exit: ");
                side = Console.ReadLine();

                if (side is "a" || side is "A") {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Random random = new Random();
                    pick = random.Next(0, attackers.Length);
                    string randomOperator = attackers[pick];
                    Console.WriteLine("\nYour operator is " + randomOperator);
                }

                else if (side is "d" || side is "D") {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Random random = new Random();
                    pick = random.Next(0, defenders.Length);
                    string randomOperator = defenders[pick];
                    Console.WriteLine("\nYour operator is " + randomOperator);
                }
                else if (side is "e" || side is "E") {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\n \nThank you for using my Operator generator \nHave a nice day \n:) \n \n");
                    System.Threading.Thread.Sleep(3000);
                    break;
                }
                else {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid character");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        }
    }
}
