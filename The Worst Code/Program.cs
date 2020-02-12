using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Worst_Code
{
    class Program
    {
        public string input;
        public int inPut;
        public bool sameNumber;

        static void Main( string[] args )
        {
            bool sameNumber = false;
            Adding adding = new Adding();
            Multiply multiply = new Multiply();

            Console.WriteLine("Welcome");
            Console.WriteLine("to the best");
            Console.WriteLine("calculation machine");
            Console.WriteLine("EVER!");
            Console.WriteLine("Please enter one number you want to add");
            

            string input1 = Console.ReadLine();
            int inPut1 = Convert.ToInt32(input1);

            Console.WriteLine("and then now enter the next number");

            string input2 = Console.ReadLine();
            int inPut2 = Convert.ToInt32(input2);

            Console.WriteLine("So you want to add {0} and {1}" , input1 , input2);

            //adding.SameNumber(inPut1 , inPut2);
            
            if (input1==input2)
            {
                sameNumber = true;
                if(sameNumber == true )
                {
                    int result1 = adding.AddingTo(inPut1 , inPut2);

                    Console.WriteLine("Result are = " + result1);
                }
                
            }
            else
            {
                sameNumber = false;
            }

            if ( inPut1 != inPut2 )
            {
                sameNumber = false;
                int result2 = multiply.MultiplyTo(inPut1, inPut2);

                Console.WriteLine("Result are = " + result2);
            }

            Console.ReadLine();
        }
    }
}
