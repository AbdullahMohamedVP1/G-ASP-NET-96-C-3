using System.Text;

namespace Assginment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            //Declare string title = "clean code";.
            //Call title.ToUpper() and store it in a new variable upperTitle.
            //Print both title and upperTitle to show that title did not change

            //string title = "clean code";
            //string UpperTitle = title.ToUpper();
            //Console.WriteLine($"normal: {title}");
            //Console.WriteLine($"Upper: {UpperTitle}");

            #endregion

            #region Question2
            //Declare two separate string variables,
            //both set to the literal "Clean Code".
            //Use ReferenceEquals() to check if they point to the same object in memory.

            //string book1 = "clean code";
            //string book2 = "clean code";
            //Console.WriteLine(object.ReferenceEquals(book1 , book2));

            #endregion

            #region Question3
            //Create a StringBuilder, Append() the text "Book List",
            //then Append() " - Updated" onto the same object.
            //Print the final result. 

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book list");
            //sb.Append(" - Updated");

            //Console.WriteLine(sb);

            #endregion

            #region Question 4
            // Using the StringBuilder from the question above,
            // use Replace() to change "Book List" into "Library".
            // Print the result.

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book list");
            //sb.Append(" - Updated");

            //sb.Replace("Book list", "Library");

            //Console.WriteLine(sb);
            #endregion

            #region Question 5
            // Given string title = "Clean Code";
            // and int pages = 464;
            // build the sentence "Book: Clean Code, Pages: 464" using the + operator.

            //string title = "Clean Code";
            //int pages = 464;

            //string sentence1 = "Book: " + title + ", Pages: " + pages;

            //Console.WriteLine(sentence1);
            #endregion

            #region Question 6
            // Build the same sentence as above,
            // but using string interpolation ($"...").

            //string title = "Clean Code";
            //int pages = 464;
            //string sentence2 = $"Book: {title}, Pages: {pages}";

            //Console.WriteLine(sentence2);
            #endregion

            #region Question 7
            // Build the same sentence again,
            // but using string.Format().

            //string title = "Clean Code";
            //int pages = 464;
            //string sentence3 = string.Format("Book: {0}, Pages: {1}", title, pages);

            //Console.WriteLine(sentence3);
            #endregion

            #region Question 8
            // Given int pages = 464;
            // write an if / else statement that prints "Long Book" if pages is greater than 300,
            // otherwise prints "Short Book".

            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion

            #region Question 9
            // Given int pages = 464;
            // and bool isAvailable = true;,
            // print "You can borrow this book" only if pages is greater than 300 and isAvailable is true.
            // Use the && operator.

            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Question 10
            // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.


            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Question 11
            // Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel (same rule as question 8: long if pages > 300).
            //int pages = 464;
            //string Ternary = pages > 300 ? "Long book" : "short book";

            //Console.WriteLine(Ternary);
            #endregion

            #region Question 12
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number.

            //string[] books =
            //{
            //    "Clean Code",
            //    "The Pragmatic Programmer",
            //    "Refactoring"
            //};

            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}  {books[i]}");
            //}
            #endregion

            #region Question 13
            // Using the same books array, use a while loop to print every book title.

            //int index = 0;
            //string[] books =
            //{
            //    "Clean Code",
            //    "The Pragmatic Programmer",
            //    "Refactoring"
            //};

            //while (index < books.Length)
            //{
            //    Console.WriteLine(books[index]);
            //    index++;
            //}
            #endregion
        }
    }
}
