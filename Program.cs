class Program
{
    public static void Main(string[] args)
    {
        string[] students = { "A", "B", "C", "D", "E", "F", "G", "H", };
        Console.Write("Enter a student's name : ");
        string input_name = Console.ReadLine();
        bool isExist = false;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Equals(input_name))
            {
                Console.WriteLine($"Student {students[i]} in class!!");
                isExist = true;
                break;
            }
        }
        if (!isExist)
        {
            Console.WriteLine($"Student not in class!!");
        }

    }
}