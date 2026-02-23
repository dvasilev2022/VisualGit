namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .ToList();

            int n = int.Parse(Console.ReadLine());

           
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Reverse")
                {
                    array.Reverse();
                }
                else if (command[0] == "Distinct")
                {
                    array = array.Distinct().ToList();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];
                    array[index] = value;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
