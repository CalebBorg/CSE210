using System.ComponentModel;

public class Breathing : Activity{



public Breathing(int duration, int pauseTime) : base(duration, pauseTime){
_duration = duration;
_pauseTime = pauseTime;
_activityName = "Breathing Activity";
_description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
}

//SWAPS BACK AND FORTH BETWEEN TELLING THE USER TO BREATHE IN AND BREATHE OUT. SHOWS A 5 SECOND TIMER BETWEEN EACH BREATH
public void BreatheInAndOut(){
    Breathing breathing = new Breathing(_duration, _pauseTime);
    int timer = 0;
    int cycles = 0;
    while(timer < _duration){
                        Console.Clear();
                        if (cycles%2 > 0){
                            Console.WriteLine("Breathe Out... ");
                        }
                        else {
                            Console.WriteLine("Breathe In... ");
                        }
                        breathing.Countdown(5);
                        cycles ++;
                        timer = timer + 5;
                    }
}

}