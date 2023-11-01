using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

public class Activity{

protected int _duration;
protected int _pauseTime;
protected string _description;
protected string _activityName;

public Activity(int duration, int pauseTime){
    _duration = duration;
    _pauseTime = pauseTime;
    _activityName = "";
    _description = "";
}

public int GetDuration(){
    return _duration;
}

public string GetName(){
    return _activityName;
}

public string GetDescription(){
    return _description;
}

public int GetPauseTime(){
    return _pauseTime;
}

public void DisplaySummary(string activityName, string description){
    Console.WriteLine($"You've chosen the {activityName}. {description} ");
}

public void DisplayRandomPrompt(List<string> prompts){
    Random random = new Random();
    Console.WriteLine(prompts[random.Next(0,prompts.Count())]);
}



public void Pause(){
    Thread.Sleep(_pauseTime);
}

public void DisplayEnd(string activityName, int duration){
    Console.WriteLine($"You've finished the {activityName}. It lasted for {duration} seconds.");
}

public void Spinner(int duration){
    int timeRemaining = duration;
    int frame = 0;
    List<string> spinnerFrames = new List<string>();
    spinnerFrames.Add(@"
    /\
    \ ");
    spinnerFrames.Add(@"
    /\
     /");
    spinnerFrames.Add(@"
     \
    \/");
    spinnerFrames.Add(@"
    / 
    \/");

    while(timeRemaining > 0){
        Console.Clear();
        Console.Write(spinnerFrames[frame]);
        timeRemaining --;
        Thread.Sleep(1000);
        frame ++;
        if (frame > 3){
            frame = 0;
        }
    }
}

public void Countdown(int duration){
    int timeRemaining = duration;
    while(timeRemaining > 0){
        Console.Write(timeRemaining);
        Thread.Sleep(1000);
        timeRemaining --;
        Console.Clear();
    }
}


}