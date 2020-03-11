using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post("First Post!", "There is just so much to learn and not enough time!!");
            Console.WriteLine(post1);

            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            post1.UpVote();
            Console.WriteLine(post1);

            post1.DownVote();
            post1.DownVote();
            Console.WriteLine(post1);

            post1.Title = "New Title"; // Error: Cannot edit Title after Post is created
            post1.VoteCount = 20; // Error: Cannot manually adjust VoteCount

        } // Main method
    
    } // Program class

} // Exercise2_StackOverflowPost namespace
