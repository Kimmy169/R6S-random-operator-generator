namespace Rainbow_6_Siege_random_operator_generator
{
    using System;

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
            string[] attackers = new string[31] { "Sledge", "Thatcher", "Ash", "Thermite", "Montagne", "Twitch", "Blitz", "IQ", "Fuze", "Glaz", "Buck", "Blackbeard", "Capitao", "Hibana", "Jackal", "Ying", "Zofia", "Dokkaebi", "Finka", "Lion", "Maverick", "Nomad", "Gridlock", "Nokk", "Amaru", "Kali", "Iana", "Ace", "Zero", "Flores", "Osa" };

            string[] defenders = new string[31] { "Smoke", "Mute", "Castle", "Pulse", "Rook", "Doc", "Bandit", "Jäger", "Kapkan", "Tachanka", "Frost", "Valkyrie", "Caveira", "Echo", "Mira", "Lesion", "Ela", "Vigil", "Maestro", "Alibi", "Clash", "Kaid", "Mozzie", "Warden", "Goyo", "Wamai", "Oryx", "Melusi", "Aruni", "Thunderbird", "Thorn" };

            Console.Write("Imput your nickname: ");
            string nickname = Console.ReadLine();

            Console.WriteLine("\nHello " + nickname);

            Console.Write("\nChoose side (A: for attakcer | D: for defender): ");
            string side = Console.ReadLine();

            if (side is "a" || side is "A")
            {
                Random random = new Random();
                int pick = random.Next(0, attackers.Length);
                string randomOperator = attackers[pick];

                Console.WriteLine("\nYour operator is " + randomOperator);
            }
            else if (side is "d" || side is "D")
            {
                Random random = new Random();
                int pick = random.Next(0, defenders.Length);
                string randomOperator = defenders[pick];

                Console.WriteLine("\nYour operator is " + randomOperator);
            }
            else
            {
                Console.WriteLine("\nInvalid character");
            }
        }
    }
}
