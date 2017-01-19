using System;
using System.Collections.Generic;

namespace Task_1
{
    /// <summary>
    /// Main class
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Sort function
        /// </summary>
        /// <param name="value">Unsorted dictonary</param>
        /// <returns>Sorted dictonary</returns>
        static public Dictionary<string, string> Sort (Dictionary<string, string> cards)
        {
            Dictionary<string, string> sortedcards = new Dictionary<string, string>();
            string nextCity = null;

            foreach (var c in cards)
            {
                if (!cards.ContainsValue(c.Key))
                {
                    sortedcards.Add(c.Key, c.Value);
                    nextCity = c.Value;
                    break;
                }
            }

            while (cards.ContainsKey(nextCity))
            {
                sortedcards.Add(nextCity, cards[nextCity]);
                nextCity = cards[nextCity];
            }

            return sortedcards;
        }

        /// <summary>
        /// Enter point method
        /// </summary>
        static public void Main()
        {
            Dictionary<string, string> cards = new Dictionary<string, string>
            {
                   {"Кельн", "Москва"},
                   {"Мельбурн", "Кельн"},
                   {"Москва", "Париж"},

            };

            Dictionary<string, string> sortedcards = Sort(cards);

            foreach (var c in sortedcards)
            {
                Console.WriteLine("{0} - {1}", c.Key, c.Value);
            }

        }
    }
}
