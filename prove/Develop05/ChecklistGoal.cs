using System.ComponentModel;

public class ChecklistGoal:Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name,string description,string points,int target,int bonus ) :base (name,description,points){
        _target=target;
        _bonus=bonus;
    }

    public void RecordEvent(){
        _amountCompleted++;
    }
    public bool IsComplete(){
        return _amountCompleted>=_target;
    }
    public string GetDetailsString(){
        return $"Completed {_amountCompleted}/{_target} times ";
    }
    public string GetStringRepresentation(){
        return $"Checklist Goal: {_shortName} - {_description} ({_points} points)";
    }
 }       