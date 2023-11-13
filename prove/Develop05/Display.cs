using System.Runtime.CompilerServices;

public class Display{

int _totalPoints = 0;
protected List<Goal> _goals = new List<Goal>();
string _fileName;
string _menuText;
int _action;

public void DisplayGoals(){
    foreach(Goal goal in _goals){
        Console.WriteLine();
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine(goal.GetType());
        Console.WriteLine(goal.GetDescription());
        if (goal.GetGoalType() == "simple"){
            if (goal.GetCompletion() == 1){
                Console.WriteLine("Completion: [x]");
            }
            else{
                Console.WriteLine("Completion: [ ]");
            }
        }
        else if(goal.GetGoalType() == "eternal"){
            Console.WriteLine($"Completions: [{goal.GetCompletion()}]");
        }
        else{
            Console.WriteLine($"Completions: [{goal.GetCompletion()}/{goal.GetNumberOfItems()}]");
        }
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine();


    }
}

public void Load(){

}

public void Save(){

}


public void CreateGoal(string type, string description, int points, int pointsPerItem, int numberOfItems, bool canBeCompleted){
    
    if(type == "simple"){
        _goals.Add(new Simple(points, description, type, canBeCompleted));
        Console.WriteLine("working");
    }
    else if(type == "eternal"){
        _goals.Add(new Eternal(points, description, type, canBeCompleted));
    }
    else{
        _goals.Add(new Checklist(points, description, type, pointsPerItem, numberOfItems, canBeCompleted));
    }
}


public void RecordEvent(int goalNumber){
    if(_goals[goalNumber-1].CheckCanBeComplete()){
        _goals[goalNumber-1].SetCompletion();
        _totalPoints = _totalPoints + _goals[goalNumber-1].GetPoints();
    }
    else{
        Console.WriteLine("Cannot complete this action");
    }
}

public int GetPoints(){
    return _totalPoints;
}

public List<Goal> GetGoals(){
    return _goals;
}

public void SetAction(int action){
    _action = action;
}

public void IncreasePoints(int points){
    _totalPoints = _totalPoints + points;
}

}