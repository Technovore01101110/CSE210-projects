class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _totalPoints;

    public GoalManager()
    {
        _totalPoints = 0;
    }
    public void CreateGoal(int userChoice, string nameP, string descriptionP, int pointsP, int totalRoundsP = 0, int bonusP = 0)
    {
        Goal goal;

        if (userChoice == 1)
        {
            goal = new Goal(nameP, descriptionP, pointsP);

            
        }
        else if (userChoice  == 2)
        {
            goal = new EternalGoal(nameP, descriptionP, pointsP);
        }
        else
        {
            goal = new ChecklistGoal(nameP, descriptionP, pointsP, totalRoundsP, bonusP);
        }

        _goals.Add(goal);
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");

        for (int iGoal = 0; iGoal < _goals.Count; iGoal++)
        {
            Console.Write($"{iGoal + 1}. ");
            _goals[iGoal].Display();
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter file = new StreamWriter(fileName))
        {
            file.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal);
            }

        }
    }

    public void LoadGoals(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);

        _totalPoints = int.Parse(lines[0]);

        for (int iLine = 1; iLine < lines.Length; iLine++)
        {
            string[] goalParts = lines[iLine].Split("|");
            Goal goalInsert;

            if (goalParts[0] == "SimpleGoal")
            {
                bool finished = bool.Parse(goalParts[4]);
                
                if (finished)
                {
                    goalInsert = new Goal(goalParts[1], goalParts[2],
                                          int.Parse(goalParts[3]),
                                          DateTime.Parse(goalParts[5]),
                                          bool.Parse(goalParts[4])
                                          );
                }
                else
                {
                    goalInsert = new Goal(goalParts[1], goalParts[2],
                                          int.Parse(goalParts[3]),
                                          bool.Parse(goalParts[4])
                                          );
                }
            }
            else if (goalParts[0] == "EternalGoal"){
                goalInsert = new EternalGoal(goalParts[1],
                                                  goalParts[2],
                                                  int.Parse(goalParts[3])
                                                  );
            }
            else
            {
                if (goalParts[5] == goalParts[6])
                    {
                        goalInsert = new ChecklistGoal(goalParts[1], 
                                                            goalParts[2],
                                                            int.Parse(goalParts[3]),
                                                            int.Parse(goalParts[5]),
                                                            int.Parse(goalParts[4]),
                                                            DateTime.Parse(goalParts[7]),
                                                            int.Parse(goalParts[6]),
                                                            true
                                                            );
                }
                else
                {
                    goalInsert = new ChecklistGoal(goalParts[1], 
                                                        goalParts[2],
                                                        int.Parse(goalParts[3]),
                                                        int.Parse(goalParts[5]),
                                                        int.Parse(goalParts[4]),
                                                        int.Parse(goalParts[6])
                                                        );
                }
            }
            _goals.Add(goalInsert);
        }
    }

    public void CompleteGoal(int iGoalP)
    {
        iGoalP -= 1;
        if (!_goals[iGoalP].IsDone())
        {
            _goals[iGoalP].CompleteGoal();
            _totalPoints += _goals[iGoalP].GetPoints();
            Console.WriteLine($"You now have {_totalPoints} points.");
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}