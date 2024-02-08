namespace LaçoForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach (var ve in vect)
            {
                Console.WriteLine(ve);
            }
        }
    }
}