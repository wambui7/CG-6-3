using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            string alicestring = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, ‘and what is the use of a book,’ thought Alice ‘without pictures or conversation?’";

            Console.WriteLine("aliceString");

            Console.WriteLine(" to search for a name in the passage");

            string searchname = Console.ReadLine();

            bool termFound = FindTerm(searchname, alicestring);

            while (searchname != "")
            {
                if (termFound == true)
            }


            {
                Console.WriteLine("Term \"" + searchname + "\" was found.");
                Console.WriteLine("to search for a name in the passage");

                searchname = Console.ReadLine();
                termFound = FindTerm(searchname, alicestring);
            


            
            else if (termFound == false)
                {
                    Console.WriteLine("Term \"" + searchname + "\" was found.");
                    Console.WriteLine("to search for a name in the passage");
                    searchname = Console.ReadLine();
                    termFound = FindTerm(searchname, alicestring);


                }

            }
        }

        private static bool FindTerm(string searchname, string alicestring)
        {
            bool termfound = Change.Uppercase;
            return termfound;
        }
    }
}
