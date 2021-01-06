using System;
using System.Linq;
using System.Text;
using ConvertLibrary;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {

         
           
            Console.WriteLine("Output the first character(1) or convert(2)");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter one hundred to stop");
                        string input = "";
                        bool check = false;
                        do
                        {
                            input = Console.ReadLine();
                            if (input != null && input != "" && input != "stop")
                            {
                                Console.WriteLine(input[0]);

                            }
                            if (input == "stop")
                            {
                                check = true;
                            }
                            else
                            {
                                Console.WriteLine("Empty line");
                            }
                        }
                        while (check != true);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter the string");
                        string input = Console.ReadLine();
                        var convert=Class1.Convert(input.ToCharArray());
                        
                        Console.WriteLine($"It was {input}, type {input.GetType()}");
                        if (input.Length>convert.Count)
                        {
                            Console.WriteLine("Invalid character");
                        }
                        foreach (var item in convert)
                        {
                            Console.WriteLine($"It has become {item}, type {item.GetType()}");
                        }
                        break;
                    }

            }
            Console.WriteLine();
          
           
           
        }
    }
}
