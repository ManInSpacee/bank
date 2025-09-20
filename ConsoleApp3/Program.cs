
class Program
{
    static void Main()
    {
        int[] nominals = { 5000, 2000, 1000, 500, 200, 100 };
        while (true) {
            Console.WriteLine("Введите нужную сумму (не более 150.000 и кратную 100)");
            int input = int.Parse(Console.ReadLine());
            if (input % 100 == 0 && input <= 150000)
            {
                foreach (var nominal in nominals)
                {
                    int sum = input / nominal;
                    if (sum > 0)
                    {
                        Console.WriteLine($"{nominal}Р: {sum} куп.");
                    }
                    input %= nominal;

                }
            }
            
        }
    }
}