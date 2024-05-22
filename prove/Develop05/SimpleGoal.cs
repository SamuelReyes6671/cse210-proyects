using System.ComponentModel;

public class SimpleGoal:Goal{
    private bool _isComplete;

    public SimpleGoal(string name,string desctiption,string points):base(name,desctiption,points){

    }
    public override void RecordEvent(){}
    public override bool IsComplete(){}
    public override string GetStringrepresentation(){}
}