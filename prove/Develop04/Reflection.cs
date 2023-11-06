public class Reflection : Activity{


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
_pauseTime = pauseTime;
_description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
_activityName = "Reflection Activity";
}

public List<string> GetPrompts(){
    return _prompts;
}

//DIPLAYS A RANDOM QUESTION, PAUSES, THEN SHOWS A SPINNER FOR 10 SECONDS AND REPEATES UNTIL THE TIMER HAS BEEN GOING LONGER THAN THE DURATION
public void DisplayRandomQuestion(int duration){
    int timer = _pauseTime/1000;
    Reflection reflection = new Reflection(_duration, _pauseTime);
    while (timer < duration){
        Random random = new Random();
        Console.Clear();
        Console.WriteLine(_questions[random.Next(0,_questions.Count())]);
        reflection.Pause();
        Spinner(10);
        timer = timer + _pauseTime + 10;
    }
    Console.Clear();
}
}
