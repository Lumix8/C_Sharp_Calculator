using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using MenuSystem;

namespace ConsoleApp
{
    class Program
    {
        private static double Current = 0.0;
        static void Main(string[] args)
        {
            Console.Clear();
            CurrentCurrent();            
            var mainMenu = new Menu("Calculator Main", EMenuLevel.Root);
            mainMenu.AddMenuItems(new List<MenuItem>()
            {
                new MenuItem("B", "Binary operations", SubmenuBinary),
                new MenuItem("U", "Unary operations", SubmenuUnary),
                new MenuItem("S", "Set value", SetValue),
                new MenuItem("Z", "Set value to zero", SetZero),
            });
            mainMenu.Run();
        }
        
        public static string SubmenuBinary()
        {
            var menu = new Menu("Binary", EMenuLevel.First);
            menu.AddMenuItems(new List<MenuItem>()
            {
                new MenuItem("+", "Add", Add),
                new MenuItem("-", "Subtract", Subtract),
                new MenuItem("/", "Divide", Divide),
                new MenuItem("*", "Multiply", Multiply),
                new MenuItem("^", "X power Y", Power),
            });
            CurrentCurrent();
            var res = menu.Run();
            return res;
        }
        
        public static string SubmenuUnary()
        {
            var menu = new Menu("Unary", EMenuLevel.First);
            menu.AddMenuItems(new List<MenuItem>()
            {
                new MenuItem("N", "Negate", Negate),
                new MenuItem("S", "Sqrt", Sqrt),
                new MenuItem("Q", "Square", Square),
                new MenuItem("A", "Abs value", Abs),
            });
            CurrentCurrent();
            var res = menu.Run();
            return res;
        }

        public static string Add()
        {
            CurrentCurrent();
            Console.WriteLine("plus");
            Console.Write("number: ");
            var n = Console.ReadLine()?.Trim();
            double.TryParse(n, out var converted);
            Current += converted;
            NewCurrent(); 
            
            return "";
        }

        public static string Subtract()
        {
            CurrentCurrent();
            Console.WriteLine("minus");
            Console.Write("number: ");
            var n = Console.ReadLine()?.Trim();
            double.TryParse(n, out var converted);
            Current -= converted;
            NewCurrent(); 
            
            return "";
        }
        
        public static string Divide()
        {
            CurrentCurrent();
            Console.WriteLine("divide by");
            Console.Write("number: ");
            var n = Console.ReadLine()?.Trim();
            double.TryParse(n, out var converted);
            Current /= converted;
            NewCurrent(); 
            
            return "";
        }
        
        public static string Multiply()
        {
            CurrentCurrent();
            Console.WriteLine("multiply for");
            Console.Write("number: ");
            var n = Console.ReadLine()?.Trim();
            double.TryParse(n, out var converted);
            Current *= converted;
            NewCurrent(); 
            
            return "";
        }
        
        public static string Power()
        {
            CurrentCurrent();
            Console.WriteLine("at the power of");
            Console.Write("number: ");
            var n = Console.ReadLine()?.Trim();
            double.TryParse(n, out var converted);
            Current = Math.Pow(Current, converted);
            NewCurrent();  
            
            return "";
        }
        
        public static string Negate()
        {
            CurrentCurrent();
            Console.WriteLine("Negating the number");
            Current *= -1;
            NewCurrent();      
            
            return "";
        }
        
        public static string Sqrt()
        {
            CurrentCurrent();
            Console.WriteLine("Finding the root");
            Current = Math.Sqrt(Current);
            NewCurrent();     
            
            return "";
        }
        
        public static string Square()
        {
            CurrentCurrent();
            Console.WriteLine("Squaring the value");
            Current = Math.Pow(Current, 2);
            NewCurrent();      
            
            return "";
        }
        
        public static string Abs()
        {
            CurrentCurrent();
            Console.WriteLine("calculating the absolute value");
            Current = Math.Abs(Current);
            NewCurrent();
            
            return "";
        }
        
        public static string SetZero()
        {
            CurrentCurrent();
            Console.WriteLine("setting value to zero");
            Current = 0.0;
            NewCurrent();
            
            return "";
        }
        
        public static string SetValue()
        {
            CurrentCurrent();
            Console.Write("Set the current number: ");
            var n = Console.ReadLine()?.Trim();
            double.TryParse(n, out var converted);
            Current = converted;
            NewCurrent(); 
            
            return "";
        }

        public static string CurrentCurrent()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Current value ===> " + Current);
            Console.ResetColor();

            return "";
        }

        public static string NewCurrent()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("New current value ===> " + Current);
            Console.ResetColor();

            return "";
        }
    }
}
