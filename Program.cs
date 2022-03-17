using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {2340, 4523, 342,123,332,435,6575,324,654,435 };
            
            Console.WriteLine(EvenNumber(num));


        }

        
    
        public static int EvenNumber(int[] number)
        {
            var sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%2==0)
                {
                    sum++;
                }
                else
                {
                    
                }


            }
            return sum;
        }





    }
}
