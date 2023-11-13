using System.Runtime;

public abstract class Goal{

int _points;
int _completion = 0;
string _type;
string _description;
int _numberOfItems = 0;
bool _canBeCompleted;

public Goal(int points, string description, string type, bool canBeCompleted){
    _points = points;
    _description = description;
    _type = type;
    _canBeCompleted = canBeCompleted;
}

abstract public void SetCompletion();

public string GetDescription(){
    return _description;
}

abstract public int GetCompletion();

public string GetGoalType(){
    return _type;
}

abstract public int GetNumberOfItems();


abstract public int GetPoints();


abstract public bool CheckCanBeComplete();


}