using system;
namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter your password");
            int passCode = Console.ReadLine();
            Console.WriteLine("Your username is: " + passCode);
        }
    }
}