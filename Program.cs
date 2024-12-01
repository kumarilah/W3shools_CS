using System;
namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter your PIN");
            string passcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Your PIN is: " + passcode);

        }
    }
}