public class Reflection : Activity{

string _description;
string _activityName;
List<string> _questions = new List<string>{
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};
List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."};



public Reflection(int duration, int pauseTime) : base(duration, pauseTime){
_duration = duration;
_description = "  ";
_pauseTime = pauseTime;
_activityName = "Breathing";
}

public void DisplayRandomPrompt(){
    Random random = new Random();
    Console.WriteLine(_prompts[random.Next(0,_prompts.Count())]);
    Thread.Sleep(5000);
}
public void DisplayRandomQuestion(int duration){
    int timer = 5;
    while (timer < duration){
        Random random = new Random();
        Console.Clear();
        Console.WriteLine(_questions[random.Next(0,_questions.Count())]);
        Thread.Sleep(5000);
        Spinner(10);
        timer = timer + 15;
    }
    Console.Clear();
}
}
