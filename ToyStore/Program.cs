using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toyList = new List<string>() {"action figure", "stuffed animal", "Legos" };

            toyList.Add("Barbie");
            toyList.Add("Remote-Controlled Car");
            toyList.Add("Yo-yo");

            //foreach (string toy in toyList)
            //{
            //    Console.WriteLine(toy);
            //}

            //equivalent for loop would read:
            //for (int i = 0; i < toyList.Count; i++)
            //{Console.WriteLine(toyList[i]);}

            Console.WriteLine(toyList[0]);

            Console.WriteLine(toyList.Count);


            toyList.Remove("Barbie");

            Console.WriteLine(toyList.Count);

                //Insert allows us to put a new element in the list
                //AND
                //Specify which index we want for that element.

            toyList.Insert(0, "Kite");
            toyList.Insert(2, "Baby doll");
            toyList.Insert(1, "Plastic dinosaur");

           //foreach (string toy in toyList)
           // {
           //     Console.WriteLine(toy);
           // }

                //The Properties and Methods which we will use the most are
                //.Count 
                //.Insert()
                //.Add()
                //.Remove()

            //Another method that we will often use is .Contains()
            //It returns a Boolean value

            if (toyList.Contains("Plastic dinosaur"))
            {
                Console.WriteLine("Daniel would never buy the dino.");
            }
            else
            {
                Console.WriteLine("Daniel might buy any of these toys.");
            }

            List<string> employeeNames = new List<string>();
        }
    }
}
