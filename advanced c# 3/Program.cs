namespace advanced_c__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            /*
            Create a program that manages student grades using One Of Collections

            Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            Print the collection, Count, first and last grade
            Sort the grades ascending, then print
            Get the first grade above 90
            Get all grades below 75 (failing grades)
            Remove all failing grades (below 75)
            Check if any grade equals 100
            Create a List<string> where each grade becomes "Grade: X"
            */

            //code answer

            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine("Grades: " + string.Join(", ", grades));
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First: " + grades.First());
            //Console.WriteLine("Last: " + grades.Last());

            //grades.Sort();
            //Console.WriteLine("Sorted: " + string.Join(", ", grades));

            //var firstAbove90 = grades.FirstOrDefault(g => g > 90);
            //Console.WriteLine("First grade > 90: " + firstAbove90);

            //var failing = grades.Where(g => g < 75).ToList();
            //Console.WriteLine("Failing grades: " + string.Join(", ", failing));

            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("After removing failing: " + string.Join(", ", grades));

            //Console.WriteLine("Contains 100? " + grades.Contains(100));

            //List<string> gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            //Console.WriteLine("Formatted: " + string.Join(", ", gradeStrings));
            #endregion

        }
    }
}
