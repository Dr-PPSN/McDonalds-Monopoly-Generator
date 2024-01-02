namespace McDonalds_Monopoly_generator
{
    internal class Program
    {
        static void Main(string[] args)
        // args[0] = number of codes to generate
        // args[1] = lenght of codes
        // args[0] == -h || --help || -H || --HELP || -help || --Help || -Help || --help = help
        {
            if (args.Length == 0)
            {
                GenerateAndPrint(1, 10);
            }
            else if (args.Length == 1)
            {
                if (args[0] == "-h" || args[0] == "--help" || args[0] == "-H" || args[0] == "--HELP" || args[0] == "-help" || args[0] == "--Help" || args[0] == "-Help" || args[0] == "--help")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("             ,,,                   ,,,             \r\n          ,,,,,,,,,.           ,,,,,,,,,,         \r\n        ,,,,     ,,,,         ,,,,     ,,,,       \r\n       ,,,,       ,,,,,     ,,,,,       ,,,,      \r\n      ,,,,         ,,,,,   ,,,,,         ,,,,     \r\n     ,,,,,          ,,,,, ,,,,,          ,,,,,    \r\n    ,,,,,           ,,,,,,,,,,,           ,,,,,   \r\n   ,,,,,,            ,,,,,,,,,            ,,,,,,  \r\n   ,,,,,             ,,,,,,,,,             ,,,,,  \r\n  ,,,,,,             ,,,,,,,,,             ,,,,,, \r\n  ,,,,,,              ,,,,,,,              ,,,,,, \r\n ,,,,,,               ,,,,,,,               ,,,,,,\r\n ,,,,,,               ,,,,,,,               ,,,,,,\r\n ,,,,,,               ,,,,,,,               ,,,,,,\r\n ,,,,,,               ,,,,,,,               ,,,,,,\r\n ,,,,,,               ,,,,,,,               ,,,,,,\r\n,,,,,,,               ,,,,,,,               ,,,,,,\r\n,,,,,,,                                     ,,,,,,");
                    Console.WriteLine("McDonalds Monopoly generator");
                    Console.WriteLine("Usage: McDonalds_Monopoly_generator.exe [number of codes] [lenght of codes]");
                    Console.WriteLine("Example: McDonalds_Monopoly_generator.exe 1 10");
                    Console.ResetColor();
                }
                else
                {
                    GenerateAndPrint(int.Parse(args[0]), 10);
                }
            }
            else if (args.Length == 2)
            {
                GenerateAndPrint(int.Parse(args[0]), int.Parse(args[1]));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid arguments");
                Console.ResetColor();
            }
        }
        static void GenerateAndPrint(int count, int lenght)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Generate(lenght) + "\n");
            }
        }
        static string Generate(int lenght)
        {
            //create a code with the lenght of lenght and numbers from 0 to 9 and letters from A to Z
            string code = "";
            Random random = new Random();
            for (int i = 0; i < lenght; i++)
            {
                int randomInt = random.Next(0, 36);
                if (randomInt < 10)
                {
                    code += randomInt.ToString();
                }
                else
                {
                    code += (char)(randomInt + 55);
                }
            }
            return code;
        }
    }
}