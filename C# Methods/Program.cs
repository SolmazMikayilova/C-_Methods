namespace C__Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int[] ints = { 12, -32, 54 };
              Console.WriteLine(Min(ints)); */ //Task(a)(1.method)

            // Min(2,5,-52,87,98);//Task(a)(2.method)

            int result_1 = Area(4);
            int result_2 = Area(4, 5);
            int result_3 = Area(4, 5, 8);
            int result_4 = Area(4, 5, 8, 10);

            Console.WriteLine(result_1);//Task(b)(1.method)

            // Area(1, 2, 3, 4);//Task(b)(2.method)
        }

        //Task(a)(1.method)
        /* public  static int Min(int[] numbers) 
             {
                 int min = numbers[0];
                 for (int i = 0; i < numbers.Length; i++)
                 {

                    if (numbers[i]< min)
                    {
                       min = numbers[i];
                    } 
                }
                return min;
            } */


        //Task(a)(2.method)
        /*  public  static void Min(params int[] numbers) 
            {
                int min = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {

                   if (numbers[i]< min)
                   {
                      min = numbers[i];
                   } 
               }
               Console.WriteLine(min);
           } */


        //Task (b)(1.method)

        public static int Area(int r)
        {
            int p = 3;
            int S = p * (r * r);
            return S;
        }
        public static int Area(int a, int b)
        {
            int S = a * b;
            return S;
        }
        public static int Area(int a, int b, int c)
        {
            int S = 2 * (a * b + a * c + b * c);
            return S;
        }
        public static int Area(int a, int b, int c, int r)
        {
            int p = (a + b + c) / 2;
            int S = p * r;
            return S;
        }

        //Task (b)(2.method)
        /* public static void Area(int r)
         {
             int p = 3;
             int S = p * (r * r);
             Console.WriteLine(S);
         }
         public static void Area(int a, int b)
         {
             int S = a * b;
             Console.WriteLine(S) ;
         }
         public static void Area(int a, int b, int c)
         {
             int S = 2 * (a * b + a * c + b * c);
             Console.WriteLine(S) ;
         }
         public static void Area(int a, int b, int c, int r)
         {
             int p = (a + b + c) / 2;
             int S = p * r;
             Console.WriteLine(S);
         }

         */
    }
}

