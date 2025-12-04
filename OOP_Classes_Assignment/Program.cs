using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes_Assignment
{
    
    public class Person
    {
        public string Name;
        public int Age;

        public void Details()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    
    public class Vehicle
    {
        public string Brand;
        public string Color;

        public Vehicle(string brand, string color)
        {
            Brand = brand;
            Color = color;
        }

        public void Brake() => Console.WriteLine("Brake!");
        public void Horn() => Console.WriteLine("Horn!");
        public void Accelerate() => Console.WriteLine("Accelerating...");
    }

    
    public class Account
    {
        private string AccountTitle;
        private double Balance;

        public Account(string title, double balance)
        {
            AccountTitle = title;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount} deposited.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn.");
            }
            else
            {
                Console.WriteLine("Not enough balance.");
            }
        }

        public void BalanceAvailable() =>
            Console.WriteLine($"Balance: {Balance}");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Ali", Age = 18 };
            p.Details();

            Console.WriteLine("");

            Vehicle v = new Vehicle("Honda", "Black");
            Console.WriteLine($"Brand: {v.Brand}, Color: {v.Color}");
            v.Accelerate();
            v.Brake();
            v.Horn();

            Console.WriteLine("");

            Account acc = new Account("Ali's Account", 3000);
            acc.BalanceAvailable();
            acc.Deposit(500);
            acc.Withdraw(1000);
            acc.BalanceAvailable();

            Console.ReadLine(); 
        }
    }
}
