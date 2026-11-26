namespace OOPsDemo
{
    internal class TestDictionary
    {
        public static void Main()
        {
            Dictionary<int, string> players = new Dictionary<int, string>();

            players.Add(1, "Dhoni");
            players.Add(2, "Virat");
            players.Add(3, "Rohit");
            players.Add(4, "Shikhar");
            players.Add(5, "Jadeja");

            Console.WriteLine("Players in the Dictionary:" + players[2]);

            if (players.ContainsKey(3))
            {
                players[3] = "Tilak";
            }
            else
            {
                Console.WriteLine("Key is not present!!!");
            }
            Console.WriteLine(players[3]);

            foreach (KeyValuePair<int, string> player in players)
            {
                Console.WriteLine(player.Key + " " + player.Value);

            }
        }
    }
}
