using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shouldContinue = false;
            bool isInputValid = false;
            string input = null;

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("");
            do
            {
                shouldContinue = false;
                do
                {
                    Console.WriteLine("There are 10 movies in this list.");
                    Console.Write("What category are you interested in?(Animated, Drama, Horror, SciFi) ");
                    input = Console.ReadLine();

                    DisplayMoviesByCategory();

                } while (!isInputValid);
            } while (shouldContinue);
        }

        public static void DisplayMoviesByCategory(string category)
        {
             
        }

        static ArrayList Movies = new ArrayList()
        {
            new Movie("Spirted Away", "Animated"),
            new Movie("Zootopia", "Animated"),
            new Movie("Inside Out", "Animated"),
            new Movie("Cast Away", "Drama"),
            new Movie("Finding Forrester", "Drama"),
            new Movie("Halloween", "Horror"),
            new Movie("Mandy", "Horror"),
            new Movie("Climax", "Horror"),
            new Movie("Mad Max: Fury Road", "SciFi"),
            new Movie("Blade", "SciFi"),
        };
    }
}




//store a list of 10 movies and display them by category.
//user enters category of Animated, Drama, Horror, SciFi
//ask user to continue

//Movie class should provide two private fields: title and category. Both fields should be String
//The class should also provide a constructor that accepts a title and category as parameters and uses the values paases to it to intialize its fields
//user enters a category the program should read out all the movies in said category in an arraylist
