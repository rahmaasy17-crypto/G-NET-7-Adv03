using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            #region 1-2
            List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };

            //foreach (int i in grades)
            //{
            //    Console.Write( $"{i}");
            //}
            // Console.WriteLine(grades.Count);
            // Console.WriteLine(grades.First());// or  Console.WriteLine(grades.FirstOrDefault()); or  Console.WriteLine(grades[0]);
            // Console.WriteLine(grades.LastOrDefault()); //or Console.WriteLine(grades[grades.Count-1]); or  Console.WriteLine(grades.Last());

            #endregion
            #region 3
            //grades.Sort();
            //foreach (int i in grades)
            //{
            //    Console.WriteLine($"{i}");
            //}
            #endregion
            #region 4
            //var first = grades.FirstOrDefault(g => g > 90); // take predicate  can also use find()
            //Console.WriteLine(first);
            #endregion
            #region 5
            //var failing_grades = grades.FindAll(g => g < 75);
            //foreach (int i in failing_grades)
            //{
            //    Console.WriteLine($"{i}");
            //}
            #endregion
            #region 6-7
            //grades.RemoveAll(g => g < 75);

            //Console.WriteLine(grades.Exists(g => g == 100));
            #endregion
            #region 8
            //List<string> textGrades = new();
            //foreach (var g in grades)
            //{
            //    textGrades.Add("Grade: " + g);
            //}
            //foreach (var i in textGrades)
            //{
            //    Console.WriteLine($"{i}");
            //}
            #endregion
            #endregion
            #region Exercise 2: Leaderboard
            // //1
            // SortedDictionary<int, string> leaderboard = new() {
            // [500]= "Ahmed",
            //[200]= "Sara",
            //[800]= "Ali",
            // [350]= "Mona"};
            //2
            //foreach (var item in leaderboard)
            // Console.WriteLine(item.Key + " :: " + item.Value);

            //// 3
            //    Console.WriteLine(leaderboard.FirstOrDefault().Key);
            //Console.WriteLine(leaderboard.FirstOrDefault().Value);


            //  4
            //Console.WriteLine(leaderboard.ContainsKey(500));

            //// 5
            //       if (leaderboard.TryGetValue(999, out string p))
            //    Console.WriteLine(p);
            //else
            //    Console.WriteLine("Not Found");

            // remove
            //leaderboard.Remove(200);
            //foreach (var item in leaderboard)
            //    Console.WriteLine(item.Key + " :: " + item.Value);
            #endregion
            #region Exercise 3: Phone Book
            ////1
            //Dictionary<string, int> phoneBook = new() {

            //    ["Ahmed"] = 111,
            //    ["Eman"]=222,
            //  [  "Ali"]= 333,
            //   [ "Noha"]= 444 };

            //// 2
            //phoneBook["Ali"] =555;

            //// 3
            //try
            //{
            //    phoneBook.Add("Ahmed", 888);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Already Exist");
            //}

            //// 4
            //bool newe = phoneBook.TryAdd("Ahmed", 888);
            //Console.WriteLine(newe);

            //// 5
            //Console.WriteLine(phoneBook.ContainsKey("Ali"));

            //// 6
            //if (phoneBook.TryGetValue("Ali", out  int num))
            //    Console.WriteLine(num);
            //else
            //    Console.WriteLine("Not Found");

            //// 7
            //foreach (var key in phoneBook.Keys)
            //  Console.Write(key + " ");


            //// 8 
            //foreach (var val in phoneBook.Values)
            //    Console.Write(val + " ");

            #endregion
            #region Exercise 4: Unique Email Validator
            //1,2,3
            HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase){ "ahmed@test.com","AHMED@test.com","sara@test.com", "Sara@Test.Com"};
           //  Console.WriteLine(emails.Count); // 2 Because HashSet prevents duplicates, and the comparer makes the comparison case-insensitive[not care it write in capital or small]

            //4
            HashSet<int> A = new() { 1, 2, 3, 4, 5 };
            HashSet<int> B = new() { 4, 5, 6, 7, 8 };
            // Union :
            //A.UnionWith(B);  
            // foreach (var item in A)
            // {
            //     Console.WriteLine(item);
            // }
            // Intersect :
            //A.IntersectWith(B);     
            //foreach (var item in A)
            //{
            //    Console.WriteLine(item);
            //}
            //// Except :
            //A.ExceptWith(B);
            //foreach (var item in A)
            //{
            //    Console.WriteLine(item);
            //}

            // 5
            //HashSet<int> subset = new () { 1, 2 };
            //Console.WriteLine(subset.IsSubsetOf(A));   
            #endregion
            #region Exercise 5: Print Queue Simulator
            Queue<string> queue = new();

            queue.Enqueue("Report.pdf");
            queue.Enqueue("Invoice.pdf");
            queue.Enqueue("Letter.docx");
            queue.Enqueue("Resume.pdf");
            queue.Enqueue("Photo.jpg");

            //// 1
            //foreach (var doc in queue)
            //    Console.Write(doc + " ");
            //Console.WriteLine();
            //Console.WriteLine("Count: " + queue.Count);

            //// 2
            //Console.WriteLine(queue.Peek());

            //// 3
            //while (queue.Count > 0)
            //{
            //    Console.WriteLine($"Printing: [{queue.Dequeue()}]");
            //}

            // 4
            //queue is empty > There is nothing to remove So ISexist returns false and No exception is thrown
            //bool ISexist = queue.TryDequeue(out string result);
            //Console.WriteLine(ISexist);
          

            #endregion
            #region Exercise 6: Browser History (Undo)
            Stack<string> history = new();
            //1
            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");

            // 2
            Console.WriteLine(history.Peek());

            //  3
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Leaving: " + history.Pop()); //catch and remove 3 elements
            }

            // 4
            Console.WriteLine(history.Peek());

            // 5
            history.Clear();
            //Stack is empty > There is nothing to remove So ISexist returns false and No exception is thrown
            bool ISexist = history.TryPop(out string page);
            Console.WriteLine(ISexist);
            #endregion
        }
    }
}
