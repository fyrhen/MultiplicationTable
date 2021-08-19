using System;

namespace Tabuada {
    public class Tabuada {
        
        public static void Main() {
            Console.WriteLine("Tabuada de 2");
            for (int i =1; i<=10; i++) {
                Console.WriteLine("2*{0}={1}", i, 2 * i);
            }

            Console.WriteLine("\r\nTabuada de 3");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("3*{0}={1}", i, 3 * i);
            }

            Console.WriteLine("\r\nTabuada de 5");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("5*{0}={1}", i, 5 * i);
            }

            Console.WriteLine("\r\nTabuada de 7");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("7*{0}={1}", i, 7 * i);
            }

            Console.WriteLine("\r\nTabuada de 10");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("10*{0}={1}", i, 10 * i);
            }

            Console.Read();
        }
    }
}
