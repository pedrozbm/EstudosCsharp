namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Pedro");
            list.Add("Richard");

            list.Insert(2, "Marco");
            //Insere na posição 2

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("List count: " + list.Count);
            //conta os elementos

            //Buscando dados
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);


            //Filtrar a lista:
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------");

            //Remover elementos:
            list.RemoveRange(2, 2);

            list.RemoveAt(3);

            list.Remove("Alex");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}