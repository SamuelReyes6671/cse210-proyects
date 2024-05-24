using System.ComponentModel;

public class SimpleGoal:Goal{
    private bool _isComplete;

    public SimpleGoal(string name,string desctiption,string points):base(name,desctiption,points){
        _isComplete=false;
    }
    public override void RecordEvent(){
        _isComplete=true;
    }
    public override bool IsComplete(){
        return _isComplete;
    }
    public override string GetStringrepresentation(){
        return $"Simple Goal: {_shortName} - {_description} ({_points} points)";
    }
}