using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak_Group3
{
    class Card
    {
        //variables
        private int mySuit; //The suit of the card (spades, hearts, diamonds, clubs)
        private int myRank; //The rank of the card (Ace - King)
        

        //mutators
        //set the card's suit
        public void SetSuit(int suit)
        {
            if (suit < 5 && suit > 0)
            {
                mySuit = suit;
            }
            else
            {
                throw(new ArgumentOutOfRangeException(suit + " is out of range. Only values 1-4 acceptable."));
            }
        }

        //set the card's rank
        public void SetRank(int rank)
        {
            if (rank < 14 && rank > 0)
            {
                myRank = rank;
            }
            else
            {
                throw(new ArgumentOutOfRangeException(rank + " is out of range. Only values 1-13 acceptable."));
            }
        }

        //accessors
        //get the card's suit
        public int GetSuit()
        {
            return mySuit;
        }
        //get the card's rnak
        public int GetRank()
        {
            return myRank;
        }

        //constructor
        public Card(int suit, int rank)
        {
            try
            {
                SetSuit(suit);
                SetRank(rank);
            }
            catch (ArgumentOutOfRangeException e)
            {
                e.ToString();
            }
            
        }
    }
}
