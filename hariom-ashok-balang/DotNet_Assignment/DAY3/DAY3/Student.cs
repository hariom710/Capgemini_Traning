class Student
{
    public int Marks;

    public virtual string GetGrade()
    {
        return "N/A";
    }
}

class SchoolStudent : Student
{
    public override string GetGrade()
    {
        if (Marks >= 90) return "A";
        if (Marks >= 75) return "B";
        return "C";
    }
}

class CollegeStudent : Student
{
    public override string GetGrade()
    {
        if (Marks >= 85) return "Distinction";
        if (Marks >= 70) return "First Class";
        return "Pass";
    }
}