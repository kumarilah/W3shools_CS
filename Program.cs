using System;
namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your PIN");
            int passcode = int.Parse(Console.ReadLine());
            Console.WriteLine("Your username is " + username + " and your PIN is " + passcode);
        }
    }
}