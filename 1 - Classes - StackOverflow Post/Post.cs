using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_StackOverflowPost
{
    class Post
    {
        public int VoteCount { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime PublishDateTime { get; private set; }

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            PublishDateTime = DateTime.Now;
        }

        public void UpVote()
        {
            VoteCount++;
        }

        public void DownVote()
        {
            VoteCount--;
        }

        public override string ToString()
        {
            return $"Title: {Title}\n" +
                   $"Description: {Description}\n" +
                   $"Publish Date and Time: {PublishDateTime}\n" +
                   $"Votes: { VoteCount}\n";
        }

    } // Post class

} // Exercise2_StackOverflowPost namespace
