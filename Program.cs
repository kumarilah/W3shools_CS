using System;
namespace MyApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter your PIN");
            Int passcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your PIN is: " + passcode);

        }
    }
}