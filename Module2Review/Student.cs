namespace Module2Review;

public class Student
{
    //Define class properties
    public string Name { get; set; }
    public int Id { get; set; }
    public List<double> Grades { get; set; } = new List<double>{100.0, 90.0, 80.0, 70.0, 60.0};

    // First Method To aDD gRADE
    public void AddGrade(double grade)
    {
      Grades.Add(grade);  
    }
    
    public Student()
    {
        
    }
    
}