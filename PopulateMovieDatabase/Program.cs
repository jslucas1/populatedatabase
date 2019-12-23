using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PopulateMovieDatabase
{
    class Program
    {
        private static Book myBook;
        static void Main(string[] args)
        {
            /*
            StreamReader inFile = new StreamReader("input.txt");
            String cwid = inFile.ReadLine();

            while(cwid != null)
            {
                Console.WriteLine(cwid);
                myBook = new Book();

                myBook.title = "2001: A Space Odyssey";
                myBook.author = "Arthur C.Clarke";
                myBook.genre = "Science Fiction";
                myBook.copies = 4;
                myBook.length = 402;
                myBook.isbn = "9780451452733";
                myBook.cover = "https://i.imgur.com/4guWejW.jpg";
                myBook.cwid = cwid;

                BookFile.SaveBook(myBook, cwid, "new");
                Thread.Sleep(2000);

                myBook.title = "The Hobbit";
                myBook.author = "J. R. R. Tolkien";
                myBook.genre = "Fantasy";
                myBook.copies = 10;
                myBook.length = 665;
                myBook.isbn = "9789402306538";
                myBook.cover = "https://i.imgur.com/9sd5pVy.jpg";
                myBook.cwid = cwid;

                BookFile.SaveBook(myBook, cwid, "new");
                Thread.Sleep(2000);

                myBook.title = "IT";
                myBook.author = "Stephen King";
                myBook.genre = "Horror";
                myBook.copies = 10;
                myBook.length = 2695;
                myBook.isbn = "9781101154922";
                myBook.cover = "https://i.imgur.com/tg1l4Xl.jpg";
                myBook.cwid = cwid;

                BookFile.SaveBook(myBook, cwid, "new");
                Thread.Sleep(2000);

                cwid = inFile.ReadLine();

            }

            inFile.Close();
            Console.ReadKey();
            */

            StreamReader inFile = new StreamReader("games.csv");
            String input = inFile.ReadLine();
            int count = 0;
            while (input != null)
            {
                Console.WriteLine(count);
                string[] temp = input.Split(',');
                string favorite = temp[0];
                string underdog = temp[1];
                double line = double.Parse(temp[2]);
                int week = int.Parse(temp[3]);
                string date = temp[4];
                string time = temp[5];
                string homeTeam = temp[9];

                Game myGame = new Game(favorite, underdog, line, week, date, time, homeTeam);
                Console.WriteLine(myGame.Favorite);
                GameFile.SaveGame(myGame);
                count++;

                input = inFile.ReadLine();

            }

            inFile.Close();
        }
    }
}
