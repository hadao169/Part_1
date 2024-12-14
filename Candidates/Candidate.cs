using System;

namespace part_1
{
    public class Candidate
    {
        public int numOfVotes;
        // Declare properties
        public  string Firstname { get; set; }
        public  string Lastname {  get; set; }
        public  string Party { get; set; }

        public int Votes
        { 
          get {  return numOfVotes; }
          set
          {
                if (value >= 0) {
                    numOfVotes = value;
                }
                else
                {
                    numOfVotes = 0;
                }
          }
        }
        
        //Initialize constructor method
        public Candidate( string first, string last, string party, int votes)
        {
            Firstname = first;
            Lastname = last ;
            Party = party;
            Votes = votes;
        }
        // Override ToString method
        public override string ToString() {
            return $"{Lastname}, {Firstname} ({Party}): {Votes}";
        }
    }
}
