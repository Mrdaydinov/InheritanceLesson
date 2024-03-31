namespace InheritanceLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            student.Grades = new int[] { 1, 2, 3, 4, 5, 7, 8, 10 };

            foreach (int i in student.Grades)
                Console.WriteLine(i);

        }
    }
}
