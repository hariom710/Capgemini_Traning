namespace Problem3
{
    internal class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Greet();
            var student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            student.Study();
            var professor = new Professor();
            professor.SetAge(45);
            professor.Greet();
            professor.Explain();
        }
    }
}
