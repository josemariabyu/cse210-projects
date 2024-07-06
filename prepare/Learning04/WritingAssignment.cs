using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    // Method to get the student's name from the base class
    public string GetStudentName()
    {
        return this.GetSummary().Split('-')[0].Trim();
    }
}
