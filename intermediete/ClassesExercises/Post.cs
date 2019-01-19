using System;

namespace Intermediete_Exercises
{
    //Design a class called Post.This class models a StackOverflow post.It should have properties
    //for title, description and the date/time it was created.We should be able to up-vote or down-vote
    //a post.We should also be able to see the current vote value.In the main method, create a post,
    //up-vote and down-vote it a few times and then display the the current vote value.
    //In this exercise, you will learn that a StackOverflow post should provide methods for up-voting
    //and down-voting.You should not give the ability to set the Vote property from the outside,
    //because otherwise, you may accidentally change the votes of a class to 0 or to a random
    //number.And this is how we create bugs in

    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public readonly DateTime CreationDate = DateTime.Now;
        public int voteValue { get; private set; }

        public Post() { }

        public Post(string title, string desc)
            :this()
        {
            Title = title; Description = desc;
        }

        public void Upvote()
        {
            voteValue++;
        }

        public void Downvote()
        {
            if (voteValue > 0)
                voteValue--;
        }

        public void Work(string input)
        {
            var post = new Post();
            while (input != "1" || input != "2" || input != "3")
            {
                Console.WriteLine("1 - Upvote, 2 - Downvote, " +
                    "3 - Show votes, Else - Exit");
                input = Console.ReadLine();
                if (input == "1")
                    post.Upvote();

                else if (input == "2")
                    post.Downvote();

                else if (input == "3")
                    Console.WriteLine("Votes: {0}", post.voteValue);

                else
                    break;
            }
        }

    }
}
