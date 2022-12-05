using System;
using System.Collections.Generic;

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
            CalculateWinner2();
            
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
                        bool correctOutput = false;

                        while (!correctOutput)
                        {
                            Console.Write("Score {0} (w/d/l): ", j + 1);
                            string tempInput = Console.ReadLine();
                            string tempResult = "";
    
                            switch (tempInput)
                            {
                                case "w":
                                    tempResult = "Win";
                                    correctOutput = true;
                                    break;
                                case "d":
                                    tempResult = "Draw";
                                    correctOutput = true;
                                    break;
                                case "l":
                                    tempResult = "Loss";
                                    correctOutput = true;
                                    break;
                                default:
                                    Console.WriteLine("Input is invalid. Please try again.");
                                    break;
                            }
                            
                            teamsArray[i].results[j] = tempResult;
                        }
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

            void CalculateWinner2()
            {
                int highestScore = -1;
                List<Team> winningTeams = new List<Team>();
                foreach (Team team in teamsArray)
                {
                    if (team.score > highestScore)
                    {
                        highestScore = team.score;
                        winningTeams = new List<Team>();
                        winningTeams.Add(team);
                    } else if (team.score == highestScore)
                    {
                        winningTeams.Add(team);
                    }
                }

                if (winningTeams.Count == 1)
                {
                    Console.WriteLine("The winning team is {0} with a score of {1}", winningTeams[0].name, winningTeams[0].score);
                } else if (winningTeams.Count >= 2)
                {
                    Console.WriteLine("We have a draw - the winning teams and their score are:");
                    foreach (Team team in winningTeams)
                    {
                        Console.WriteLine("{0}: {1}", team.name, team.score);
                    }
                }
            }
        }
    }
}