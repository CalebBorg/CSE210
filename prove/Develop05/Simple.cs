using System.ComponentModel;

public class Simple : Goal{

int _points;
string _description;
string _type;
int _completion;
bool _canBeCompleted;

public Simple(int points, string description, string type, bool canBeCompleted, int completion) : base(points, description, type, canBeCompleted, completion){
    _points = points;
    _description = description;
    _type = type;
    _canBeCompleted = canBeCompleted;
    _completion = completion;
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


override public bool CheckCanBeComplete(){
    if (_canBeCompleted){
        return true;
    }
    else{
        return false;
    }
}



}