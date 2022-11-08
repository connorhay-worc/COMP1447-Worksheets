using System;

namespace Week7
{
    public class Example08
    {
        public static void A() {
            // COMP1447 Week 7 -- Example 08a
            // Rock-Paper-Scissors
            // https://en.wikipedia.org/wiki/Rock%E2%80%93paper%E2%80%93scissors
            // Rock blunts scissors, scissors cuts paper, paper covers rock
            Random randomGenerator = new Random();
            int countDraws = 0;
            int countWins = 0;
            int countLosses = 0;
            int a, b;
            for (int i=1;i<=30;i++)
            {
                // Rock=0 Paper=1 Scissors=2
                a = randomGenerator.Next(0, 3);
                b = randomGenerator.Next(0, 3);
                if (a == 0)
                {
                    if (b == 0)
                    {
                        // Rock v Rock (draw)
                        countDraws++;
                    }
                    else if (b == 1)
                    {
                        // Rock v Paper (loss)
                        countLosses++;
                    }
                    else
                    {
                        // Rock v Scissors (win)
                        countWins++;
                        
                    }
                }
                else if (a == 1)
                {
                    if (b == 0)
                    {
                        // Paper v Rock (win)
                        countWins++;
                    }
                    else if (b == 1)
                    {
                        // Paper v Paper (draw)
                        countDraws++;
                    }
                    else
                    {
                        // Paper v Scissors (loss)
                        countLosses++;
                    }
                }
                else
                {
                    if (b == 0)
                    {
                        // Scissors v Rock (loss)
                        countLosses++;
                    }
                    else if (b == 1)
                    {
                        // Scissors v Paper (win)
                        countWins++;
                    }
                    else
                    {
                        // Scissors v Scissors (draw)
                        countDraws++;
                        
                    }
                }
            }
            Console.WriteLine("Wins=" + countWins + " Draws=" + countDraws + " Losses=" +
                              countLosses);  
        }
    }
}