using HW_W4_01.ChoiceString;
using HW_W4_01.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W4_01.ChoiceNumber
{
    internal class NumberClass : ParentClass
    {
        static List<int> randomNumbers = new List<int>();

        static List<int> resultNumbers = new List<int>();





        private  void GenerateRandomNumbers()
        {


            Random rnd = new Random();
            
                Console.Write("Enter Array Size : ");
             var    countInput = Int32.Parse(Console.ReadLine());
         

            for (int i = 0; i < countInput; i++)
            {
                randomNumbers.Add(rnd.Next(0,99));
            }
            Console.WriteLine("".PadLeft(50, '*'));
            //Console.WriteLine("All  numbers Are:");

            //PrintAll();
            Console.WriteLine("".PadLeft(50, '*'));
            Console.WriteLine("The result number Are:");
         
            NumberMethod();
        }


        private void PrintAll()
        {
            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }
        }
        private void NumberMethod()
        {
            var linq = from number in randomNumbers
                       where ((number * number) > 2 || Math.Sqrt(number) < 4)
                       orderby number descending
                       select number;
            resultNumbers.AddRange(linq.Skip(10).Take(10));
            foreach (var number in resultNumbers)
            {
                Console.WriteLine($"number {number}");
            }



        }

        public void InputExample()
        {
            Console.WriteLine("Enter a number: ");
            var Example = Console.ReadLine();
            try
            {



               
                    var exampl = int.Parse(Example);
                bool result = ((exampl > -2147483648) && (exampl < 2147483647));
                    switch (result)
{
                case(true):
                {

                   // Console.WriteLine($"Your  choice is number");
                    Console.WriteLine();
                    GenerateRandomNumbers();


                    break;
                }

                    case (false):
                       Console.WriteLine($"Your  input is roung");
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
