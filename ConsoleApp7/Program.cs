namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> array = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;

                string[] command = input.Split();

                if (command[0] == "Reverse" && command.Length == 1)
                {
                    array.Reverse();
                }
                else if (command[0] == "Distinct" && command.Length == 1)
                {
                    array = array.Distinct().ToList();
                }
                else if (command[0] == "Replace" && command.Length == 3)
                {
                    bool isIndexValid = int.TryParse(command[1], out int index);

                    if (!isIndexValid || index < 0 || index >= array.Count)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    array[index] = command[2];
                }
                else
                {
                    Console.WriteLine("Invalid command!");
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
