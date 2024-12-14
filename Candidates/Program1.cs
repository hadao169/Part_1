using part_1;

namespace PART_1
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            List<Candidate> candidates = new List<Candidate>
            {
                new Candidate("Jane", "Douglas", "Oxbox", 12724),
                new Candidate("Ellen", "Rose", "Oxtra", 10214),
                new Candidate("Luke", "Westaway", "Oxtra", 9011),
                new Candidate("Andy", "Farrant", "Oxbox", 13319),
                new Candidate("Mike", "Channel", "Oxbox", 8953),
                new Candidate("Johnny", "Chiodini", "Oxventure", 10466)
            };

            // Iterate through the list and print each candidate
            foreach (var candidate in candidates)
            {
                Console.WriteLine(candidate);
            }

        }
    }
}
