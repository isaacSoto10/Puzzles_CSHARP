using System;
using System.Collections.Generic;

namespace FirstCSharp
{
    class Program
    {
        public static string randomArray(int[] num){
            int max = 0;
            int min = num.Length;
            int sum = 0;
            for(int i = 0; i < num.Length; i++)
            
            {                    
                if (num[i] >= max)
                    {
                        max = num[i];
                    };
                
                if(num[i] <= min)
                {
                    min = num[i];
                }
                sum = sum + i;

            }
            return $"Your max is: {max} Your min is: {min}, and your sum is: {sum}";
            
            

        }
        public static string TossCoin()
        {
            string[] coin = {"Heads", "Tails"};
            Random random = new Random();
            int start2 = random.Next(0, coin.Length);


            return coin[start2]; 
        }
        public static double TossMultipleCoins(int num)
        {
            double ratio = 0.00;
            double counter = 0;
            for(int i = 0; i < num; i++)
            {
               string call = TossCoin();
               if (call == "Heads")
               {
                   counter++;
               }
               
            }
            ratio = counter/num;
            return ratio;
            
        }
        
        
        public static List<T> Shuffle<T> (List<T> list)
        {
            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int k = rnd.Next(0, i);
                T value = list[k];
                list[k] = list[i];
                list[i] = value;
            }
            return list;
        }
        public static List<string> Names()
        {
            List<string> names = new List<string>();
            List<string> namesMoreThan5 = new List<string>();
            names.Add("Todd");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            names = Shuffle(names);
            for(int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
                if(names[i].Length > 5)
                {
                    namesMoreThan5.Add(names[i]);
                } 
            }
            return namesMoreThan5;
        }
        
        static void Main(string[] args)
        {
            int[] num = {1,2,3,4,5,6,7,8,9,25,12};
            
            Console.WriteLine(randomArray(num));
            Console.WriteLine(TossCoin());
            Console.WriteLine(TossMultipleCoins(100000));
            Names();
        }

    }

}


//Sum and Print 1-5
//Sum numbers from 1 to 5, printing out the current number and sum so far at each step of the way
//The expected output will be: Num: 1, Sum: 1, Num: 2, Sum: 3, Num: 3, Sum: 6, Num: 4, Sum: 10, Num: 5, Sum: 15
