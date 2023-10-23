using Microsoft.VisualBasic;

public class WritingAssignment : Assignment{
string _title;
string _info;

public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic){
    _studentName = studentName;
    _topic = topic;
    _title = title;
}

public string GetWritingInfo(){
    _info = $"{_title}, by {_studentName}";
    return _info;
}


}