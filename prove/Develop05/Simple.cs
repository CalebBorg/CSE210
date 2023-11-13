public class Simple : Goal{

int _points;
string _description;
string _type;
int _completion = 0;
bool _canBeCompleted;

public Simple(int points, string description, string type, bool canBeCompleted) : base(points, description, type, canBeCompleted){
    _points = points;
    _description = description;
    _type = type;
    _canBeCompleted = canBeCompleted;
}

override public void SetCompletion(){
    _completion = 1;
    _canBeCompleted = false;
}

public override int GetCompletion(){
    return _completion;
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