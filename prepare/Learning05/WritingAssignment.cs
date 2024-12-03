public class WritingAssignment : Assignment{
    private string _title;

    // Constuctor to initialize all fields
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic) // call base constuctor
    {
        _title = title;
    }
    // Method to get writing info
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}