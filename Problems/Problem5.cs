using System;

namespace DailyCodingProblems
{
    /*
     * cons(a, b) constructs a pair, and car(pair) and cdr(pair) returns the first and last element of that pair.
     * For example, car(cons(3, 4)) returns 3, and cdr(cons(3, 4)) returns 4.
     * Implement car and cdr.
     */

    public class Problem5 : IProblem
    {
        private Cons pair;

        public Problem5(int a, int b)
        {
            pair = new Cons(a, b);
        }

        public void Solve()
        {
            int carResult = Car(pair);
            int cdrResult = Cdr(pair);

            Console.WriteLine($"car(cons({pair.A}, {pair.B})) returns {carResult}\ncdr(cons({pair.A}, {pair.B})) returns {cdrResult}");
        }

        private int Car(Cons cons)
        {
            return cons.A;
        }

        private int Cdr(Cons cons)
        {
            return cons.B;
        }

        private class Cons
        {
            public int A { get; }
            public int B { get; }

            public Cons(int a, int b)
            {
                A = a;
                B = b;
            }
        }
    }
}