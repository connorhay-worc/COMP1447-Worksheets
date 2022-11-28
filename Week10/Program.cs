using System;

namespace Week10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Team[] teamsArray = new Team[3];
            AddTeams();
            PrintTeams();
            AddResults();
            PrintResults();
            CalculateScores();
            CalculateWinner();
            
            void AddTeams()
            {
                Console.WriteLine("Please enter the team names for the competition:");
    
                for (int i = 0; i < teamsArray.Length; i++)
                {
                    Console.Write("Team {0}: ", i + 1);
                    string teamName = Console.ReadLine();
                    Team tempTeam = new Team(teamName);
                    teamsArray[i] = tempTeam;
                }
            }

            void PrintTeams()
            {
                Console.WriteLine("These are the teams in the competition: ");
                foreach (Team team in teamsArray)
                {
                    Console.WriteLine(team.name);
                }
                Console.WriteLine();
            }

            void AddResults()
            {
                Console.WriteLine("For each team enter results - single character w/d/l for wind/draw/loss: ");
                for (int i = 0; i < teamsArray.Length; i++)
                {
                    Console.WriteLine("Team {0}: ", teamsArray[i].name);
                    for (int j = 0; j < teamsArray[i].results.Length; j++)
                    {
                        Console.Write("Score {0} (w/d/l): ", j + 1);
                        string tempInput = Console.ReadLine();
                        string tempResult = "";
                        if (tempInput == "w")
                        {
                            tempResult = "Win";
                        }
                        else if (tempInput == "d")
                        {
                            tempResult = "Draw";
                        }
                        else if (tempInput == "l")
                        {
                            tempResult = "Loss";
                        }
                        
                        teamsArray[i].results[j] = tempResult;
                    }
                }
                Console.WriteLine();
            }

            void PrintResults()
            {
                Console.WriteLine("These are the results for each team:");
                foreach (Team team in teamsArray)
                {
                    Console.WriteLine("{0} results:", team.name);
                    foreach (string result in team.results)
                    {
                        Console.WriteLine(result);
                    }
                }
            }

            void CalculateScores()
            {
                foreach (Team team in teamsArray)
                {
                    int tempScore = 0;
                    foreach (string result in team.results)
                    {
                        if (result == "Win")
                        {
                            tempScore += 2;
                        } else if (result == "Draw")
                        {
                            tempScore += 1;
                        }
                    }

                    team.score = tempScore;
                }
                Console.WriteLine();
            }

            void CalculateWinner()
            {
                int highestScore = 0;
                Team winningTeam = null;
                foreach (Team team in teamsArray)
                {
                    if (team.score > highestScore)
                    {
                        highestScore = team.score;
                        winningTeam = team;
                    }
                }
                Console.WriteLine("The winning team is {0} with a score of {1}", winningTeam.name, winningTeam.score);
            }
        }

        
    }
}