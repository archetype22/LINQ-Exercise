namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> VideoGames = new List<string>
            {"Call of Duty Modern Warfare II","God of War Ragnarok","Call of Duty Cold War","God of War","Assassin's Creed Valhalla" };
            
            IEnumerable<string> longVideoGames = VideoGames.OrderByDescending(x => x.Length);

            foreach (string item in longVideoGames) 
            { 
                Console.WriteLine(item);                
            }
                Console.WriteLine();
                Console.WriteLine(" ^-- All the games a parent no longer has time to play..");
        }
    }
}
