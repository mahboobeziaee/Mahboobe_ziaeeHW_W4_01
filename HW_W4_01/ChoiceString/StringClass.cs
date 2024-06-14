using HW_W4_01.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW_W4_01.ChoiceString
{
    internal class StringClass: ParentClass

    {
       static  List<string> stringList = new List<string>();



       
        private  void GenerateRandomString()
        {
            Console.Write("Enter Array Size : ");
            var countInput = Int32.Parse(Console.ReadLine());
            Random rand = new Random();

            // Choosing the size of string 
            int stringlen = rand.Next(3, 8);
            int randValue;
            string str = "";
            char letter;
            for (int strnum = 0; strnum < countInput; strnum++)
            {
                for (int i = 0; i < stringlen; i++)
                {

                    // Generating a random number. 
                    randValue = rand.Next(0, 26);


                    //convert the random number into character. 
                    if (rand.Next(0, 2) == 0)
                    {
                        letter = Convert.ToChar(randValue + 65);
                    }
                    else
                    {
                        letter = Convert.ToChar(randValue + 97);
                    }
                    str += letter;

                }
                stringList.Add(str);
                str = "";

            }

            //Console.WriteLine("".PadLeft(50, '*'));
            //Console.WriteLine("All  words Are:");

            //PrintAll();
            Console.WriteLine("".PadLeft(50, '*'));
            Console.WriteLine("The result words Are:");
            StringMethod();
        }

        private void PrintAll()
        {
            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }
        }
        private  void StringMethod()
        {
             List<string> resultList = new List<string>();
         List<string> finalltList = new List<string>();

            var linq = from str in stringList
                       where str.Contains('a') || str.Contains('H') || str.Contains('Q') || str.Contains('x')
                       orderby stringList descending
                       select str;
            resultList.AddRange(linq);
           
            if(resultList.Count() > 7)
            {
               

                finalltList.AddRange(linq.Skip(resultList.Count() - 3).Take(3));
                foreach (var str in finalltList)
                    Console.WriteLine($"string:  {str}");
            }
            else
            {
                foreach (var str in resultList)
                Console.WriteLine($"string:  {str}");
            }

        }

        public void InputExample()
        {
            Console.WriteLine("Enter a string: ");
            var Example = Console.ReadLine();
            try
            {




                // var exampl = Example.Contains()
                long x;
                bool result = !(long.TryParse(Example, out x));
                // (((exampl >= 'a') && (exampl <= 'z'))|| ((exampl >= 'A') && (exampl <= 'Z')));
               
                switch (result)
                {
                    case (true):
                        {

                          
                            Console.WriteLine();
                            GenerateRandomString();


                            break;
                        }

                    case (false):
                        Console.WriteLine($"Your  input is wrong, Try again...");
                        InputExample();

                        Console.WriteLine("".PadLeft(50, '*'));



                        break;


                    default:
                        throw new ArgumentException($"Your input is not valid.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                InputExample();
            }
        }

    }
}
