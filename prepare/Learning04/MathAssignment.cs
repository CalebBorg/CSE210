public class MathAssignment : Assignment{

string _textbookSection;
string _problems;
List<string> _homeworkList = new List<string>();

public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic){
    _studentName = studentName;
    _topic = topic;
    _textbookSection = textbookSection;
    _problems = problems;
}

public List<string> GetHomeworkList(){
    _homeworkList.Add(_textbookSection);
    _homeworkList.Add(_problems);
    return _homeworkList;
}
}