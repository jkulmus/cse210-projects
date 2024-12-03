public class MathAssignment : Assignment
{
    private string _section;
    private string _problems;

    // Constructor for initialzing all fields
    public MathAssignment(string studentName, string topic, string section, string problems) 
        : base(studentName, topic) // call base constructor 
        {
            _section = section;
            _problems = problems;
        }
        // method to get homework list
        public string GetHomeworkList()
        {
            return $"Section {_section} Problems {_problems}";
        }
}