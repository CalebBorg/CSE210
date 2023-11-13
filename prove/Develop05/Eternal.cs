public class Eternal : Goal{

int _points;
string _description;
string _type;
bool _completion = false;
int _numberOfCompletions = 0;
bool _canBeCompleted;

public Eternal(int points, string description, string type, bool canBeCompleted) : base(points, description, type, canBeCompleted){
    _points = points;
    _description = description;
    _type = type;
    _canBeCompleted = canBeCompleted;
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


}