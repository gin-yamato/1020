using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Func<int, int, string> bar = Foo1;
              string result = bar.Invoke(4, 8);



             Console.WriteLine(result);

             bar = Foo02;

             result = bar.Invoke(4, 8);

             Console.WriteLine(result);
             */
            // Console.WriteLine("Hello World!");
            // Test test = new Test();
            // test.Cry();


            /*
            Test test1 = null;
            Test Cry = null;
            Funck01(test1);
            */

            int plusResult = plus.Invoke(4, 5);
            Console.WriteLine(plusResult);
            Func<int, int, int> plus = (a, b) => a + b;

        }
        /*
        private static string Foo1(int a, int b)
        {
            return a.ToString() + "と" + b.ToString();
        }

        private static string Foo02(int a, int b)
        {
            return (a + b).ToString();
        }
        */
        //Func<int, int, int> plus = (int a, int b) => { return a + b; };

        

        /*
        private static void Funck01(Test test)
        {
            
            if ( test != null)
            {
                test.Cry();
            }
            //uetoshitahaonaji
            test?.Cry();
            //sannshougata
            string[] items;
            if(test != null)
            {
                items = test.Itmes;
            }
            else
            {
                items = null;
            }
            //kaerichi.mennba-hennsuugaataigatanobaai
            float? weight = test?.Weight;
            
        }*/
    }
    /*
    public class Test
    {
        int i = 1;
        int j = 0;
        public float Weight;

        public string[] Itmes { get; internal set; }

        public void Cry()
        {
            Console.WriteLine("jk");
            Weight = 10;
            Console.WriteLine(Weight);
        }
        
        
         
      private static void ConsoleLog(string message)
        {
            Console.WriteLine(message);

        }
        /*static void Main(string[]args)
        {
            Action<string> WriteLog = ConsoleLog;
            WriteLog("aaa");
            WriteLog.Invoke("bbb");
        }
        
       
    }*/
    
    
    
}
