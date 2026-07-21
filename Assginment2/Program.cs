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
        }
    }
}
