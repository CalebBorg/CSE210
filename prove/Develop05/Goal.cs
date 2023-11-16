using System.Runtime;

public abstract class Goal{

int _points;
int _completion;
string _type;
string _description;
int _numberOfItems = 0;
bool _canBeCompleted;

public Goal(int points, string description, string type, bool canBeCompleted, int completion){
    _points = points;
    _description = description;
    _type = type;
    _canBeCompleted = canBeCompleted;
    _completion = completion;
}

abstract public void SetCompletion();

public string GetDescription(){
    return _description;
}

abstract public int GetCompletion();

public string GetGoalType(){
    return _type;
}

virtual public int GetNumberOfItems(){
    return 0;
}


abstract public int GetPoints();


abstract public bool CheckCanBeComplete();

virtual public int GetPointsPerItem(){
    return 0;
}

}