using System;
using System.Threading;

namespace MultithreadedProgramming
{
    class Calculations1
    {
        private int S { get; }

        public Calculations1(int s) => this.S = s;

        public void Factorial()
        {
            Console.WriteLine("Запускаем дочерний поток по вычислению факториала");
            long sum = 1;
            for (var i = 1; i <= S; i++)
            {
                sum *= i;
                Console.WriteLine(sum);
            }

            Console.WriteLine("\nДочерний поток по вычислению факториала завершен\n");
        }

        public void ToFactorial()
        {
            Console.WriteLine("\nЗапускаем дочерний поток по вычислению двойного факториала\n");
            long sum = 1;
            if (S % 2 == 0) sum = 2;

            for (var i = 1; i <= S; i++)
            {
                if (S % 2 == 0 && i % 2 == 0)
                {
                    sum *= i;
                    Console.WriteLine(sum);
                }
                else if (S % 2 != 0 && i % 2 != 0)
                {
                    sum *= i;
                    Console.WriteLine(sum);
                }
            }

            Console.WriteLine("\nДочерний поток по вычислению двойного факториала завершен\n");
        }

        public void Fibonacci()
        {
            var first = 1;
            Console.Write("{0} ", first);
            var second = 1;
            if (S < 2) return;
            var count = 2;
            Console.Write("{0} ", second);
            while (S > count)
            {
                var sum = first + second;
                Console.Write("{0} ", sum);

                first = second;
                second = sum;
                count++;
            }
        }
    }
    
    class Program
    {
        static void Main()
        {
            #region nomberOne
            // Console.WriteLine("Введите значение: ");
            // var s = int.Parse(Console.ReadLine() ?? string.Empty);
            // var a = new Calculations1(s);
            // ThreadStart ts = a.Factorial;
            // ts += a.ToFactorial;
            // ts += a.Fibonacci;
            // var factorial = new Thread(a.Factorial);
            // var factorialTo = new Thread(a.ToFactorial);
            // var fibonacci = new Thread(a.Fibonacci);
            // factorial.Start();
            // factorialTo.Start();
            // fibonacci.Start();
            // if (factorial.IsAlive) 
            //     factorial.Join();
            // if (factorialTo.IsAlive) 
            //     factorialTo.Join();
            // if (fibonacci.IsAlive) 
            //     fibonacci.Join();
            #endregion

            #region nomberTo

            
            #endregion
        }
    }
}