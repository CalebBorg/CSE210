public class Eternal : Goal{

int _points;
string _description;
string _type;
int _completion;
int _numberOfCompletions = 0;
bool _canBeCompleted;

public Eternal(int points, string description, string type, bool canBeCompleted, int completion) : base(points, description, type, canBeCompleted, completion){
    _points = points;
    _description = description;
    _type = type;
    _canBeCompleted = canBeCompleted;
    _completion = completion;
}

override public void SetCompletion(){
    _numberOfCompletions ++;
}

override public int GetCompletion()
{
    return _numberOfCompletions;
}

public override int GetPoints(){
    return _points;
}

public override int GetNumberOfItems()
{
    return 0;
}
override public bool CheckCanBeComplete(){
    if (_canBeCompleted){
        return true;
    }
    else{
        return false;
    }
}

override public int GetPointsPerItem(){
    return 0;
}
}