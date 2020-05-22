using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Practice_libMgmt
{
    class DateManager
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        static DateManager()
        {
            BookLoad();
            UserLoad();
        }

        public static void BookLoad()   //xml요소들 채우기
        {
            try
            {
                string booksOutput = File.ReadAllText(@"./Books.xml");
                XElement booksXElement = XElement.Parse(booksOutput);
                Books = (from item in booksXElement.Descendants("book")
                         select new Book()
                         {
                             Isbn = item.Element("isbn").Value,
                             Name = item.Element("name").Value,
                             Publisher = item.Element("publisher").Value,
                             Page = int.Parse(item.Element("page").Value),
                             BorrowedAt = DateTime.Parse(item.Element("borrowedAt").Value),
                             isBorrowed = item.Element("isBorrowed").Value != "0" ? true : false,
                             UserId = int.Parse(item.Element("userId").Value),
                             UserName = item.Element("userName").Value
                         }).ToList<Book>();
            }
            catch(Exception)
            {
                using (StreamWriter writer = new StreamWriter(@"./Books.xml", true))
                {
                    writer.WriteLine("<books>");
                    writer.WriteLine("<book>");
                    writer.WriteLine("  <isbn></isbn>");
                    writer.WriteLine("  <page></page>");
                    writer.WriteLine("  <borrowedAt></borrowedAt>");
                    writer.WriteLine("  <isBorrowed></isBorrowed>");
                    writer.WriteLine("  <userId></userId>");
                    writer.WriteLine("  <userName></userName>");
                    writer.WriteLine("</book>");
                    writer.WriteLine("</books>");
                }
                BookLoad();
            }
        }

        public static void BookSave()       //xml파일에 저장시킬 내용(노드들)
        {
            string booksOutput = "";
            booksOutput += "<books>\n";
            foreach (var item in Books)
            {
                booksOutput += "<book>\n";
                booksOutput += "  <isbn>" + item.Isbn + "</isbn>\n";
                booksOutput += "  <name>" + item.Name + "</name>\n";
                booksOutput += "  <publisher>" + item.Publisher + "</publisher>\n";
                booksOutput += "  <page>" + item.Page + "</page>\n";
                booksOutput += "  <borrowedAt>" + item.BorrowedAt + "</borrowedAt>\n";
                booksOutput += "  <isBorrowed>" + (item.isBorrowed ? 1 : 0) + "</isBorrowed>\n";
                booksOutput += "  <userId>" + item.UserId + "</userId>\n";
                booksOutput += "  <userName>" + item.UserName + "</userName>\n";
                booksOutput += "</book>";
            }
            booksOutput += "</books>";

            File.WriteAllText(@"./Books.xml", booksOutput);
        }

        public static void UserLoad()   //xml요소들 채우기
        {
            try
            {
                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);
                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             Id = int.Parse(item.Element("id").Value),
                             Name = item.Element("name").Value,
                         }).ToList<User>();
            }
            catch (Exception)
            {
                using (StreamWriter writer = new StreamWriter(@"./Users.xml"))
                {
                    writer.WriteLine("<users>");
                    writer.WriteLine("<user>");
                    writer.WriteLine("  <id></id>");
                    writer.WriteLine("  <name></name>");
                    writer.WriteLine("</user>");
                    writer.WriteLine("</users>");
                }
                UserLoad();
            }
        }

        public static void UserSave()       //xml파일에 저장시킬 내용(노드들)
        {
            string usersOutput = "";
            usersOutput += "<users>\n";
            foreach (var item in Users)
            {
                usersOutput += "<user>\n";
                usersOutput += "  <id>" + item.Id + "</id>\n";
                usersOutput += "  <name>" + item.Name + "</name>\n";
                usersOutput += "</user>";
            }
            usersOutput += "</users>";

            File.WriteAllText(@"./Users.xml", usersOutput);
        }
    }
}
