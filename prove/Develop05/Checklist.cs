public class Checklist : Goal{


int _points;
string _description;
string _type;
int _pointsPerItem;
int _numberOfItems;
int _numberOfItemsCompleted = 0;
int _completion = 0;
bool _canBeCompleted;

public Checklist(int points, string description, string type, bool canBeCompleted, int pointsPerItem, int numberOfItems, int completion) : base(points, description, type, canBeCompleted, completion){
    _points = points;
    _description = description;
    _type = type;
    _pointsPerItem = pointsPerItem;
    _numberOfItems = numberOfItems;
    _canBeCompleted = canBeCompleted;
    _completion = completion;
}


override public void SetCompletion(){
    _numberOfItemsCompleted ++;
    if (_numberOfItemsCompleted == _numberOfItems){
        _completion = 1;
    }
}

public override int GetCompletion()
{
    return _numberOfItemsCompleted;
}

public override int GetPoints(){
    int _checklistPoints;
    if (_numberOfItems == _numberOfItemsCompleted){
        _checklistPoints = _pointsPerItem + _points;
        _canBeCompleted = false;
    }
    else{
        _checklistPoints = _pointsPerItem;
    }
    return _checklistPoints;
}

    public override int GetNumberOfItems()
    {
        return _numberOfItems;
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
    return _pointsPerItem;
}

}