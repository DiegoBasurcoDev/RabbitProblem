using System;
using System.Collections;

namespace sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            countRabbitCouple(39);
            
            Console.WriteLine("Hello World!");
        }

        public static void countRabbitCouple(int position){
            int rabbitCount = 50;
            ArrayList rabbitList = new ArrayList();

            for(int i = 1; i < rabbitCount; i++){
                if(i <= 2){
                    rabbitList.Add(1);
                }else{
                    int count = rabbitList.Count;
                    int sum = Int32.Parse(string.Format($"{rabbitList[rabbitList.Count-1]}")) + 
                    Int32.Parse(string.Format($"{rabbitList[rabbitList.Count-2]}"));
                    rabbitList.Add(sum);
                }
            }

            Console.WriteLine(rabbitList[position-1]);
        }
    }
}
