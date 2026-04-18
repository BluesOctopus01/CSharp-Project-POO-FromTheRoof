using System;

namespace FromTheRoof.Class;

public class Year
{
    private int _number;
    private List<Exam> _exams;
    private List<Course> _courses;
    private bool _isValidated = false;
    public Year(int number , List<Exam> exams, List<Course>  courses)
    {
        _number = number;
        _exams = exams;
        _courses = courses;
    }
    public void DisplayYear()
    {
        throw new NotImplementedException("IncreaseLevel n'est pas encore implémenter");
    }
}
