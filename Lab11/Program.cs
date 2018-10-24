﻿using System;
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

                    Console.WriteLine("There are 10 movies in this list.");
                    Console.Write("What category are you interested in?(Animated, Drama, Horror, SciFi) ");
                    
                do
                {
                    isInputValid = true;
                    input = Console.ReadLine();
                    if (input.Equals("Animated", StringComparison.InvariantCultureIgnoreCase))
                    {
                        DisplayMoviesByCategory("Animated");
                    }
                    else if (input.Equals("Drama", StringComparison.InvariantCultureIgnoreCase))
                    {
                        DisplayMoviesByCategory("Drama");
                    }
                    else if (input.Equals("Horror", StringComparison.InvariantCultureIgnoreCase))
                    {
                        DisplayMoviesByCategory("Horror");
                    }
                    else if (input.Equals("SciFi", StringComparison.InvariantCultureIgnoreCase))
                    {
                        DisplayMoviesByCategory("SciFi");
                    }//if the user types animated however they'd like display the movies by category. 
                    else
                    {
                        Console.WriteLine("Input is not valid. Please enter Animated, Drama, Horror, SciFi");
                        isInputValid = false;
                    }
                } while (!isInputValid);

                Console.Write("Continue? (y/n):");
                input = Console.ReadLine();//my continue statement
                if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                {
                    shouldContinue = true; //if the input is true or Y continue running
                }
            } while (shouldContinue);
        }

        public static void DisplayMoviesByCategory(string category)
        {
            foreach (Movie movie in Movies)
            {
                if (movie.Category.Equals(category))
                {
                    Console.WriteLine(movie.Title);
                }
            }
            /*ForEach movie in the ArrayList Movies.
            if the category equals what the user input display movie title.
            */
        }

        static ArrayList Movies = new ArrayList()
        {//arraylist of movies and their category
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
