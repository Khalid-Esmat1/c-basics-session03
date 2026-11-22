using System.Runtime.CompilerServices;
using System.Text;

namespace AssignmentTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"{title}   {upperTitle}");
            #endregion

            #region Q02
            string str1 = "clean code", str2 = "clean code";
            //Console.WriteLine(ReferenceEquals(str1 , str2));
            #endregion

            #region Q03
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append("-Updated");
            // Console.WriteLine(sb);
            #endregion

            #region Q04
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);
            #endregion

            #region Q05
            //string title = "Clean Code"; 
            //int pages = 464;
            //Console.WriteLine("Book : " + title + " , Pages : " + pages);

            #endregion

            #region Q06
            //Console.WriteLine($"Book : {title} , Pages : {pages}");
            #endregion

            #region Q07
            //Console.WriteLine(String.Format("Book : {0} , Pages : {1}" , title , pages));
            #endregion

            #region Q08
            int pages = 464;
            if (pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region Q09
            bool isAvailable = true;
            if (isAvailable && pages > 300)
            {
                Console.WriteLine("You can borrow this book only if pages is greater than 300 and isAvailable is true.");
            }
            else
            {
                Console.WriteLine("You can borrow this book only if pages is greater than 300 and isAvailable is true.");
            }
            #endregion

            #region Q10
            string text = "Clean Code";
            switch (text)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break ;
            }
            #endregion

            #region Q11
            int bkPages = 300;
            string label = (bkPages > 300) ? "long book" : "short book";
            Console.WriteLine(label);
            #endregion

            #region Q12
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++) 
            //{
            //    Console.WriteLine($"{i + 1} : {books[i]}");
            //}
            #endregion

            #region Q13
            //int x = 0;
            //while (x < books.Length) 
            //{
            //    Console.WriteLine($"{x + 1} : {books[x]}");
            //    x++;
            //}
            #endregion

            #region Q14
            int y = 0;
            do
            {
                Console.WriteLine("Checking....");
                y++;
            } while (y < 3);
            #endregion

            #region Q15
            foreach (string bk in books) 
            {
                Console.WriteLine(bk);
            }
            #endregion

            #region Q16
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "Refactoring")
                {
                    break;
                }
                Console.WriteLine($"{i + 1} : {books[i]}");
            }
            #endregion

            #region Q17
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine($"{i + 1} : {books[i]}");
            }
            #endregion

            #region Q18
            PrintFirstBook(books);
            #endregion
        }
        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0) return;
            Console.WriteLine(books[0]);
        }
    }
}

