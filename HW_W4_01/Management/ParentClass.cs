using HW_W4_01.ChoiceNumber;
using HW_W4_01.ChoiceString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_W4_01.Management
{
    internal class ParentClass : Program
    {
        private void LearningManagement()
        {
            var mainMessage = "Learning management system";
            Console.WriteLine(mainMessage);
            Console.WriteLine("".PadLeft(mainMessage.Length, '*'));
            Console.WriteLine("[1] Input is number".PadRight(35) + "[2] Input is string");
            Console.WriteLine("".PadLeft(mainMessage.Length, '*'));
            Console.Write("Select: > ");

        }
        public void HandleUserInput()
        {
            LearningManagement();

            StringClass stringClass = new StringClass();
            NumberClass numberClass = new NumberClass();
            var input = Console.ReadLine();
            try
            {



                switch (input)
                {
                    case "1":


                        Console.WriteLine($"Your  choice is number");
                        Console.WriteLine();
                        numberClass.InputExample();


                        break;

                    case "2":
                        Console.WriteLine($"Your  choice is string");
                        stringClass.InputExample();

                        Console.WriteLine("".PadLeft(50, '*'));



                        break;


                    default:
                        throw new ArgumentException($"Selected option is not valid. Your input: {input}");
                }
            }
            catch (Exception ex)
            {
                LearningManagement();
                HandleUserInput();
            }
        }
    }
}
