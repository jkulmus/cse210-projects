public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Getter for accessing private member variables
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }

    // Method to get summary
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}