using System;
using System.Collections.Generic;
using System.Text;

namespace TMS.DotNet06.ZooManager.Managers
{
    public class ZooManager
    {
        public string zooName { get; set; }
        public ZooManager(string zooName)
        {
            this.zooName = zooName;
        }

        public void ShowHeadLine()
        {
            Console.WriteLine($"----Welcome to {this.zooName} manager----");
        }

        public void ShowMenu()
        {
            Console.WriteLine("Add Animal :       [A]");
            Console.WriteLine("List All Animals : [L]");
            Console.WriteLine("Delete Animal :    [D]");
            Console.WriteLine("Close App :        [C]");
        }

        public void MenuHandler()
        {
            Console.Write("Choose Action : ");
            string menuInput = Console.ReadLine(); ;
            switch(menuInput)
            {
                case "A":
                    AddAnimal();
                    break;
                case "L":
                    ListAllAnimals();
                    break;
                case "D":
                    DeleteAnimal();
                    break;
                case "C":
                    CloseApp();
                    break;
                default:
                    Console.Clear();
                    ShowHeadLine();
                    ShowMenu();
                    MenuHandler();
                    break;
            }
        }

        public void AddAnimal()
        {

        }

        public void ListAllAnimals()
        {

        }

        public void DeleteAnimal()
        {

        }

        public void CloseApp()
        {
            Environment.Exit(1);
        }
    }
}
