namespace Module2Review;

class Program
{
    static void Main(string[] args)
    {
        //Create Students List
        List<Student> students = new List<Student>();
        
        //Create four instances of the Student Class
        
        //Instance One
        Student studentOne = new Student();
        
        studentOne.Name = "John";
        studentOne.Id = 1;
        studentOne.AddGrade(100.0, 70.0, 80.0);
        students.Add(studentOne);
        
        //Instance Two
        Student studentTwo = new Student();
        
        studentTwo.Name = "Jenny";
        studentTwo.Id = 2;
        studentTwo.AddGrade(95.0, 73.0, 64.0);
        students.Add(studentTwo);
        
        //Instance Three
        Student studentThree = new Student();
        
        studentThree.Name = "Mary";
        studentThree.Id = 3;
        studentThree.AddGrade(88.0, 90.0, 86.0);
        students.Add(studentThree);
        
        //Instance Four
        Student studentFour = new Student();
        
        studentFour.Name = "Jack";
        studentFour.Id = 4;
        studentFour.AddGrade(93.0, 87.0, 78.0);
        students.Add(studentFour);
        
        //Loop Through List of Students
        foreach (Student student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
            
            Console.Write("Grades: ");
            foreach (double grade in student.Grades)
            {
                Console.Write($"{grade} ");
            }

            Console.WriteLine(); // New line after grades
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade():F2}");
            Console.WriteLine(); // Extra space between students
        }
        
        //Course Info
        Course courseOne = new Course();
        courseOne.CourseName = "History";
        courseOne.CourseCode = "One";
        foreach (Student student in students)
        {
            courseOne.EnrollStudent(student);
        }
        
        //Display Students in  Course
        Console.WriteLine($"\nStudents enrolled in {courseOne.CourseName}:");
        foreach (Student student in courseOne.EnrolledStudents)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
        }

    }
}