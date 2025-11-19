using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int userMenuChoice;
        Console.Clear();
        do
        {
            Console.WriteLine($"\nYou have {goalManager.GetTotalPoints()} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal\n  2. List Goals" +
                              "\n  3. Save Goals\n  4. Load Goals" +
                              "\n  5. Record Event\n  6. Quit");
            
            Console.Write("Select choice from the menu: ");
            userMenuChoice = int.Parse(Console.ReadLine());

            switch (userMenuChoice)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalChoice = int.Parse((Console.ReadLine()));
                    if (0 < goalChoice && goalChoice <= 3){
                        
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int goalPoints = int.Parse(Console.ReadLine());
                        
                        if (goalChoice == 3)
                        {
                            Console.Write("How many times does this goal need to accomplished for a bonus? ");
                            int goalTimes = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonusPoints = int.Parse(Console.ReadLine());
    
                            goalManager.CreateGoal(goalChoice, goalName, goalDescription, goalPoints, goalTimes, bonusPoints);
                        }
                        else
                        {
                            goalManager.CreateGoal(goalChoice, goalName, goalDescription, goalPoints);
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not an option.");
                    }
                    break;
                case 2:
                    goalManager.ListGoals();
                    break;
                case 3:
                    Console.Write("What is the name of the file? ");
                    string fileName = Console.ReadLine();
                    goalManager.SaveGoals(fileName);
                    break;
                case 4:
                    Console.Write("What is the name of the file? ");
                    fileName = Console.ReadLine();
                    goalManager.LoadGoals(fileName);
                    break;
                case 5:
                    goalManager.ListGoals();
                    Console.Write("Which goal did you accomplish? ");
                    int completedGoal = int.Parse(Console.ReadLine());
                    goalManager.CompleteGoal(completedGoal);
                    break;
                default:
                    break;
            }

        }while (userMenuChoice != 6);
    }
}