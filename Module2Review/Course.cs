namespace Module2Review;

public class Course
{
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    
    // Field: a list to hold enrolled students
    public List<Student> EnrolledStudents;

    //Method to check if Student is enrolled
    public void AddEnrolledStudent(Student student)
    {
        bool alreadyEnrolled = false;

        foreach (Student enrolledStudent in EnrolledStudents)
        {
            if (student.Id == enrolledStudent.Id)
            {
                alreadyEnrolled = true;
                break;
            }

            if (alreadyEnrolled)
            {
                EnrolledStudents.Add(student);
                Console.WriteLine($"Enrolled {student.Name} student.");
            }
            else
            {
                Console.WriteLine($"Student {student.Name} is already enrolled.");
            }
        }
    }

    // Default constructor
    public Course()
    {
        // Initialize the list so it's ready to use
        EnrolledStudents = new List<Student>();
    }
}