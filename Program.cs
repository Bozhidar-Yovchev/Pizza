using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string command = Console.ReadLine();
                while (command.ToLower() != "end")
                {
                    string[] pizza = command.Split(' ').ToArray();

                    switch (pizza[0].ToLower())
                    {
                        case "dough":
                            Dough dough = new Dough(pizza[1], pizza[2], short.Parse(pizza[3]));
                            Console.WriteLine(Math.Round(dough.GetCallories(),2));
                            break;
                        case "topping": Topping topping = new Topping(pizza[1], int.Parse(pizza[2]));
                            Console.WriteLine(topping.Calories());
                            break;
                    }
                    command = Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
