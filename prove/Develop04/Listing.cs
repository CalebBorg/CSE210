using System.ComponentModel;

public class Listing : Activity{


List<string> _prompts = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
List<string> _inputs = new List<string>();

public Listing(int duration, int pauseTime) : base(duration, pauseTime){
    _duration = duration;
    _pauseTime = pauseTime;
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    _activityName = "Listing Activity";
}

//I WANTED TO MAKE GetPrompts() INHERITED FROM Activity BUT I COULDN'T FIGURE OUT HOW TO MAKE IT WORK, SO IT SHOWS UP IN Reflection AND Listing
public List<string> GetPrompts(){
    return _prompts;
}

public void SetInputs(List<string> inputs){
    _inputs = inputs;
}

//ASKS THE USER FOR INPUTS. USES DATETIME TO RECORD HOW MUCH TIME HAS PASSED. ALWAYS LETS THE USER FINISH THEIR LAST ENTRY BEFORE ENDING
public List<string> PromptInputs(int duration){
    DateTime time = DateTime.Now;
    DateTime endTime = time.AddSeconds(duration);
    _inputs.Clear();
    while(time < endTime){
        _inputs.Add(Console.ReadLine());
        time = DateTime.Now;
        
    }
    return _inputs;
}

//COUNTS THE INPUTS
public void CountInputs(){
    Console.WriteLine($"You listed {_inputs.Count()} things.");
}

}