using System.ComponentModel;

public class Breathing : Activity{

string _description;
protected string _activityName;


public Breathing(int duration, int pauseTime) : base(duration, pauseTime){
_duration = duration;
_description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
_pauseTime = pauseTime;
_activityName = "Breathing";
}


}