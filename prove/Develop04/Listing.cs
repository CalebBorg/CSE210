using System.ComponentModel;

public class Listing : Activity{

string _description;
string _activityName;
List<string> _prompts = new List<string>{
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
List<string> _inputs = new List<string>();

public Listing(int duration, int pauseTime) : base(duration, pauseTime){
    _duration = duration;
    _description = "  ";
    _pauseTime = pauseTime;
    _activityName = "Breathing";
}

public void DisplayRandomPrompt(){
    Random random = new Random();
    int randint = random.Next(0,_prompts.Count());
    Console.WriteLine(_prompts[randint]);
}

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

}