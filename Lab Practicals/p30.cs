public interface Passable
{
    bool Pass(int mark);
}

public interface Gradable
{
    string Division(int average);
}

public class Student : Passable, Gradable
{
    // Returns true if mark is 50 or above, otherwise false
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    // Returns division based on average score
    public string Division(int average)
    {
        if (average >= 75)
            return "Distinction";
        else if (average >= 60)
            return "Merit";
        else
            return "Pass";
    }

    // Entry point to demonstrate the functionality
    static void Main(string[] args)
    {
        Student student = new Student();

        // Testing Pass()
        Console.WriteLine($"Mark 72  → Pass: {student.Pass(72)}");   // True
        Console.WriteLine($"Mark 45  → Pass: {student.Pass(45)}");   // False

        // Testing Division()
        Console.WriteLine($"Average 80 → {student.Division(80)}");   // Distinction
        Console.WriteLine($"Average 65 → {student.Division(65)}");   // Merit
        Console.WriteLine($"Average 55 → {student.Division(55)}");   // Pass
    }
}
