public class Assignment{
protected string _studentName;
protected string _topic;
private string _summary;

public Assignment(string studentName, string topic){
    _studentName = studentName;
    _topic = topic;
}

public string GetSummary(){

    _summary = $"{_studentName} - {_topic}";
    return _summary;

}



}