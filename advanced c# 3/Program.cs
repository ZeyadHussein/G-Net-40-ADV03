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

            #region Exercise 2: Leaderboard
            /*
            Create a leaderboard that automatically sorts players by score.

            Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            Print all entries (they should be sorted by score automatically)
            Access the first key and first value 
            Check if score 500 exists
            Safely get the player with score 999
            Remove the player with score 200 and print the updated list
            */

            //code answer

            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //{
            //    {500, "Ahmed"},
            //    {200, "Sara"},
            //    {800, "Ali"},
            //    {350, "Mona"}
            //};

            //foreach (var item in leaderboard)
            //    Console.WriteLine($"{item.Key} => {item.Value}");

            //Console.WriteLine("First Key: " + leaderboard.First().Key);
            //Console.WriteLine("First Value: " + leaderboard.First().Value);

            //Console.WriteLine("Contains 500? " + leaderboard.ContainsKey(500));

            //if (leaderboard.TryGetValue(999, out string player))
            //    Console.WriteLine(player);
            //else
            //    Console.WriteLine("Score 999 not found");

            //leaderboard.Remove(200);

            //Console.WriteLine("After removal:");
            //foreach (var item in leaderboard)
            //    Console.WriteLine($"{item.Key} => {item.Value}");
            #endregion

            #region Exercise 3: Phone Book
            /*
            Build a phone book application.

            Create a Collection with 4 contacts (name → phone number)
            Add a new contact using [] syntax (add or update)
            Try adding a duplicate using .Add() — catch the exception
            Try adding a duplicate using .TryAdd()
            Search for a contact that doesn’t exist
            Get a contact with fallback "Not Found"
            Print all Keys and Values
            */


            //Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    {"Ahmed", "111"},
            //    {"Sara", "222"},
            //    {"Ali", "333"},
            //    {"Mona", "444"}
            //};

            //phoneBook["John"] = "555"; 

            //try
            //{
            //    phoneBook.Add("Ahmed", "999");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //bool added = phoneBook.TryAdd("Ahmed", "999");
            //Console.WriteLine("TryAdd success? " + added);

            //if (!phoneBook.ContainsKey("Omar"))
            //    Console.WriteLine("Omar not found");

            //string result = phoneBook.ContainsKey("Omar") ? phoneBook["Omar"] : "Not Found";
            //Console.WriteLine(result);

            //Console.WriteLine("Keys: " + string.Join(", ", phoneBook.Keys));
            //Console.WriteLine("Values: " + string.Join(", ", phoneBook.Values));
            #endregion


            #region Exercise 4: Unique Email Validator
            /*
            Use HashSet with case-insensitive comparer

            Add emails and print count
            Create Set A and B and perform operations
            Check subset
            */

            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};

            //Console.WriteLine("Email Count: " + emails.Count);

            //HashSet<int> A = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> B = new HashSet<int> { 4, 5, 6, 7, 8 };

            //var union = new HashSet<int>(A);
            //union.UnionWith(B);
            //Console.WriteLine("Union: " + string.Join(", ", union));

            //var intersect = new HashSet<int>(A);
            //intersect.IntersectWith(B);
            //Console.WriteLine("Intersect: " + string.Join(", ", intersect));

            //var except = new HashSet<int>(A);
            //except.ExceptWith(B);
            //Console.WriteLine("Except: " + string.Join(", ", except));

            //Console.WriteLine("Is {1,2} subset of A? " + new HashSet<int> { 1, 2 }.IsSubsetOf(A));
            #endregion


            #region Exercise 5: Print Queue Simulator
            /*
            Simulate a printer queue

            Enqueue 5 documents
            Print queue and count
            Peek next document
            Dequeue all
            TryDequeue on empty queue
            */

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Report.pdf");
            //queue.Enqueue("Invoice.pdf");
            //queue.Enqueue("Letter.docx");
            //queue.Enqueue("Resume.pdf");
            //queue.Enqueue("Photo.jpg");

            //Console.WriteLine("Queue: " + string.Join(", ", queue));
            //Console.WriteLine("Count: " + queue.Count);

            //Console.WriteLine("Next: " + queue.Peek());

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine("Printing: " + queue.Dequeue());
            //}

            //bool success = queue.TryDequeue(out string doc);
            //Console.WriteLine("TryDequeue success? " + success);
            #endregion


            #region Exercise 6: Browser History (Undo)
            /*
            Simulate browser history using Stack

            Push 5 URLs
            Peek current page
            Pop 3 times
            Print current page
            TryPop on empty stack
            */

            //Stack<string> history = new Stack<string>();
            //history.Push("google.com");
            //history.Push("github.com");
            //history.Push("stackoverflow.com");
            //history.Push("youtube.com");
            //history.Push("claude.ai");

            //Console.WriteLine("Current: " + history.Peek());

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Leaving: " + history.Pop());
            //}

            //Console.WriteLine("Current after back: " + history.Peek());

            
            //history.Clear();
            //bool popped = history.TryPop(out string page);
            //Console.WriteLine("TryPop success? " + popped);
            #endregion




        }
    }
}
