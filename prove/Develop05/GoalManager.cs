public class GoalManager{
    private List<Goal>_goals;
    private int _score;

    public GoalManager(){
        _goals=new List<Goal>();
        _score=0;
    }
    public void Start(){
        LoadGoals();
        DisplayPlayerInfo();
    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"Player Score: {_score}");
    }
    public void ListGoalNames(){
        foreach(Goal goal in _goals){
            Console.WriteLine(goal._shortName);
        }
    }
    public void ListGoalDetails(){
        foreach(Goal goal in _goals){
            Console.WriteLine(goal.GetStringRepresentation());
        }
    }
    public void CreateGoal(){}
    public void RecordEvent(){}
    public void SaveGoals(){
        string fileName="myFile.txt";
        using(StreamWriter outputfile=new StreamWriter(fileName)){
            foreach(Goal goal in _goals){
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(){}


}