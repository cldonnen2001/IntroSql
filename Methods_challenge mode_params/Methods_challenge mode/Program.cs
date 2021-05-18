using System;

namespace Methods_challenge_mode
{
    class Program
    {
        static void Main(string[] args)  // code starts/excecutes here
        {
            Console.WriteLine("Hello Team lets discuss our library capacity. How many bookcases do you have on the left and than on the right?");
            int leftside = int.Parse(Console.ReadLine());
            int rightside = int.Parse(Console.ReadLine());

            int numBookcases = NumBookcases(leftside, rightside);  // note adding is used in WriteLine line 14 and NumBookscases is used in method below as method-name line 28
            Console.WriteLine($"You have a total of {numBookcases} bookcases.");//  this is calling the variable from line 13
                                                                       // var sum = Books(10, 20);  // var versus int, var is implicite typing assumes the type based on the value = 
                                                                        //(cannot use var when declaring) var says i will become what every type the value is (compiler decides)

            Console.WriteLine($"Let's find out how many books are in the library.  You had {numBookcases} book cases.");
            Console.WriteLine("For arguemnt sakes, lets say the bookshelves are full with the same number of books on each shelf.  How many books fit on each self?");
            int bookOnShelve = int.Parse(Console.ReadLine());
            Console.WriteLine("And how many shelves are in a bookcase?");
            int numShelves = int.Parse(Console.ReadLine());

            int totalBooks = Bookcases(numBookcases, bookOnShelve, numShelves);
            Console.WriteLine($"our library has {numBookcases} bookcases.  Each bookcase has {numShelves} bookshelves and those have {bookOnShelve} books on each shelf.  This means we have a total of {totalBooks}.");

        }
        public static int NumBookcases(int leftside, int rightside)  // parameters are int leftside & ing rightside method is "numBookcases" - method needs to be descriptive
        {
            // this is the scope area
            // int sum = leftside + rightside;
            // return sum;//
            return leftside + rightside;  // this replaces line 31 & 32
        }
        public static int Bookcases(int bookOnShelve, int numShelves, int numBookcases)
        {
            return bookOnShelve * numShelves * numBookcases;
        
        }
             
    }
}
