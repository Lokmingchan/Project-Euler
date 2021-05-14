using System;
using System.Diagnostics;
using ProjectEuler.Interfaces;

namespace ProjectEuler
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string answer;
            
            do
            {
                Console.Write("Which problem's solution would you like to see: ");
                answer = Console.ReadLine();

                if (!int.TryParse(answer, out int numProblem)) continue;
                Console.WriteLine();
                GetSolution(numProblem);
                Console.WriteLine();
            } while (answer != "exit" && answer != "quit" && answer != "q" && answer != "x");
        }

        private static void GetSolution(int numProblem)
        {
            IProblem prob = null;
            string padNum = numProblem.ToString().PadLeft(3, '0');
            Type type = Type.GetType("ProjectEuler.Problems.Problem" + padNum);
            prob = (IProblem)Activator.CreateInstance(type);

            Stopwatch stopWatch = Stopwatch.StartNew();
            prob.Solution();
            stopWatch.Stop();
            Console.WriteLine("Elapsed Time: " + stopWatch.Elapsed + " / " + stopWatch.ElapsedTicks + " ticks");
        }

    }
}
