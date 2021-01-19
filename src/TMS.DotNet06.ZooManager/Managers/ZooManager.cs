using System;
using System.Collections.Generic;
using System.Text;
using TMS.DotNet06.ZooManager.Models;

namespace TMS.DotNet06.ZooManager.Managers
{
    public class ZooManager
    {
        public string zooName { get; set; }
        public IList<Wolf> wolves;
        public IList<Fox> foxes;
        public ZooManager(string zooName)
        {
            this.zooName = zooName;
            IList<Wolf> wolves = new List<Wolf>();
            this.wolves = wolves;
            IList<Fox> foxes = new List<Fox>();
            this.foxes = foxes;
        }

        public void ShowHeadLine()
        {
            Console.WriteLine($"----Welcome to {this.zooName} manager----");
        }

        public void ShowMenu()
        {
            Console.WriteLine("---------Menu----------");
            Console.WriteLine("Add Animal       -> [A]");
            Console.WriteLine("List All Animals -> [L]");
            //Console.WriteLine("Delete Animal    -> [D]");
            Console.WriteLine("Close App        -> [C]");
            Console.WriteLine("-----------------------");
        }

        public void MenuHandler()
        {
            Console.Write("Choose Action : ");
            string menuInput = Console.ReadLine(); ;
            switch(menuInput)
            {
                case "A":
                    Console.Clear();
                    ShowHeadLine();
                    Add();
                    Console.Clear();
                    ShowHeadLine();
                    Console.WriteLine("\nAnimal successfully added!\n");
                    ShowMenu();
                    MenuHandler();
                    break;
                case "L":
                    Console.Clear();
                    ShowHeadLine();
                    Show();
                    ShowMenu();
                    MenuHandler();
                    break;
                case "D":
                    Console.Clear();
                    ShowHeadLine();
                    Delete();
                    Console.Clear();
                    ShowHeadLine();
                    Console.WriteLine("\nAnimal successfully deletet!\n");
                    ShowMenu();
                    MenuHandler();
                    break;
                case "C":
                    Close();
                    break;
                default:
                    Console.Clear();
                    ShowHeadLine();
                    InvalidInput();
                    ShowMenu();
                    MenuHandler();
                    break;
            }
        }

        private void InvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR! Invalid Input!");
            Console.ResetColor();
        }

        public void Add()
        {
            Console.WriteLine("You can add only [W]olfs and [F]oxes!");
            Console.WriteLine("Choose your destiny!");

            string destiny = Console.ReadLine();
            switch(destiny)
            {
                case "W":
                    Console.Write("Input Your Wolf Name : ");
                    string wolfName = Console.ReadLine();
                    Console.Write("Input Your Wolf Age : ");
                    int wolfAge = IntInput("Input Your Wolf Age: ");
                    
                    wolves.Add(new Wolf
                    {
                        name = wolfName,
                        age = wolfAge
                    });

                    break;

                case "F":
                    Console.Write("Input Your Fox Name : ");
                    string foxName = Console.ReadLine();
                    Console.Write("Input Your Fox Age : ");
                    int foxAge = IntInput("Input Your Fox Age: ");
                    
                    foxes.Add(new Fox
                    {
                        name = foxName,
                        age = foxAge
                    });

                    break;

                default:
                    InvalidInput();
                    Add();
                    break;
            }
                
        }

        public void Show()
        {
            foreach (var item in wolves)
            {
                int i = 0;
                Console.WriteLine($"----Wolf #{i}----");
                i++;
                Console.WriteLine($"Name : {item.name}");
                Console.WriteLine($"Age : {item.age}");
                Console.Write("Wolf says :");
                item.Say();
                Console.Write("Wolf action : ");
                item.Move();
                Console.WriteLine("----------------------\n");
            }

            foreach (var item in foxes)
            {
                int i = 0;
                Console.WriteLine($"----Fox #{i}----");
                i++;
                Console.WriteLine($"Name : {item.name}");
                Console.WriteLine($"Age : {item.age}");
                Console.Write("Fox says :");
                item.Say();
                Console.Write("Fox action : ");
                item.Move();
                Console.WriteLine("----------------------\n");
            }

        }

        public void Delete()
        {
            Show();
        }

        public void Close()
        {
            Environment.Exit(1);
        }

        private int IntInput(string error)
        {
            int age;

            try
            {
                return age = int.Parse(Console.ReadLine());           
            }
            catch (Exception)
            {
                InvalidInput();
                Console.WriteLine(error);
                return IntInput(error);
            }
            
        }
    }
}
