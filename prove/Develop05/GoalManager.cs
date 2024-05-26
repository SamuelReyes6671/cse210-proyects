public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        LoadGoals();
        DisplayPlayerInfo();
        ShowGoalList();
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player Score: {_score}");
    }

    public void ShowGoalList()
    {
        Console.WriteLine("Your Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        _score += GetPointsForGoal(goal);
    }

    private int GetPointsForGoal(Goal goal)
    {
        // Additional logic to calculate points based on goal type
        return 0;
    }

    public void SaveGoals()
    {
        string fileName = "goals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        // Load goals from file (if any)
    }
}
