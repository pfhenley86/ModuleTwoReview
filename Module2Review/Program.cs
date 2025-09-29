namespace Module2Review;

class Program
{
    static void Main(string[] args)
    {
        //Create Students List
        var students = new List<double>();
        
        //Create four instances of the Student Class
        
        //Instance One
        Student studentOne = new Student();
        
        studentOne.Name = "John";
        studentOne.Id = 1;
        studentOne.AddGrade(100.0, 70.0, 80.0);
        
        //Instance Two
        Student studentTwo = new Student();
        
        studentTwo.Name = "Jenny";
        studentTwo.Id = 2;
        studentTwo.AddGrade(95.0, 73.0, 64.0);
        
        //Instance Three
        Student studentThree = new Student();
        
        studentThree.Name = "Mary";
        studentThree.Id = 3;
        studentThree.AddGrade(88.0, 90.0, 86.0);
        
        //Instance Four
        Student studentFour = new Student();
        
        studentFour.Name = "Jack";
        studentFour.Id = 4;
        studentFour.AddGrade(93.0, 87.0, 78.0);
    }
}