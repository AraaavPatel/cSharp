using System;

class Student
{
    int rollNo;
    string name;
    double marks;

    // Default constructor
    public Student()
    {
        rollNo = 0;
        name = "";
        marks = 0.0;
    }

    // Parameterized constructor
    public Student(int rollNo, string name, double marks)
    {
        this.rollNo = rollNo;
        this.name = name;
        this.marks = marks;
    }

    // Method to calculate grade based on marks
    public char CalculateGrade()
    {
        if (marks >= 90)
            return 'A';
        else if (marks >= 80)
            return 'B';
        else if (marks >= 70)
            return 'C';
        else if (marks >= 60)
            return 'D';
        else
            return 'F';
    }

    // Method to display student details
    public void DisplayDetails()
    {
        if (rollNo == 0 && name == "" && marks == 0.0)
        {
            Console.WriteLine("No Student Found");
        }
        else
        {
            Console.WriteLine($"Roll No: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Marks: {marks}");
            Console.WriteLine($"Grade: {CalculateGrade()}");
        }
    }
}

class Program
{
    static void Main()
    {
        // Using parameterized constructor
        Student student1 = new Student(7292, "Arav", 92.5);
        student1.DisplayDetails();

        Console.WriteLine();

        // Using default constructor
        Student student2 = new Student(2867, "Rohit", 85.0);
        student2.DisplayDetails();

        Student student3 = new Student(7985,"Aman",62.8);
        student3.DisplayDetails();
    }
}