using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Durak_Group3
{
    class Deck
    {
        //variables
        Card[] myDeck;
        Image[] cardImages = new Image[53];
        int myDeckSize;
        Card myTrumpCard;
        int myTrumpSuit; //set during Deal()
        int myCurrentDeckPosition = 0;//iterate through the deck

        //constructor
        public Deck(int deckSize, frmInGame gameForm)
        {

            //get the card images
            GetCardImages();

            if(deckSize == 20 || deckSize == 36 || deckSize == 52)
            {
                myDeck = new Card[deckSize];
                int deckCounter = 0; //counter for deck initialization
                int rankStart=0;
                //set which is the lowest card based on how big the deck is
                if (deckSize == 20) { rankStart = 10; }
                else if (deckSize == 36) { rankStart = 6;}
                else if (deckSize == 52) { rankStart = 1; }
                //build the deck
                for (int suit = 1; suit <=4; suit++)
                {
                    for (int rank = rankStart; rank <= (deckSize/4); rank++)
                    {
                        Card tempCard = new Card(suit, rank);
                        PictureBox tempPic = new System.Windows.Forms.PictureBox();
                        myDeck[deckCounter] = tempCard;
                        gameForm.ourDeck.Add(tempPic);
                        gameForm.ourDeck[deckCounter].BackgroundImage = cardImages[deckCounter]; //only works for 52 right now, will fix
                        gameForm.ourDeck[deckCounter].Location = new System.Drawing.Point(rank * 130 - 130, suit * 190-190);
                        gameForm.ourDeck[deckCounter].Width = 120;
                        gameForm.ourDeck[deckCounter].Height = 180;
                        gameForm.Controls.Add(gameForm.ourDeck[deckCounter]);
                        deckCounter++;
                    }
                }
                myDeckSize = deckSize;
            }
            else
            {
                throw (new ArgumentOutOfRangeException(deckSize+" is invalid. 20, 36, and 52 are valid sizes."));
            }
        }

        //shuffle the deck
        //adapted from Shuffle function of OOP Lab 4, written by Ryan Howse on 3/10/2019
        void Shuffle()
        {
            //create two PlayingCard objects to hold objects being switched
            Card temporaryCard1;
            Card temporaryCard2;

            //randomize rand() based on the computer clock
            var rand = new Random();

            //do this for as many cards as there are in the deck
            for (int deckPosition = 0; deckPosition < myDeckSize; deckPosition++)
            {
                int randomCardIndex = rand.Next(0, myDeckSize - 1);
                //set one temporary card to the next card in the deck, and the other to a random card
                temporaryCard1 = myDeck[deckPosition];
                temporaryCard2 = myDeck[randomCardIndex];
                //swap the two cards (cards may swap with itself, but it doesn't really matter)
                myDeck[deckPosition] = temporaryCard2;
                myDeck[randomCardIndex] = temporaryCard1;
            }
        }

        //deal the cards at the beginning
        public void Deal(Player player, Player ai)
        {
            Shuffle();
            for(int card = 0; card < 6; card++)
            {
                player.cards[card] = myDeck[myCurrentDeckPosition];
                myCurrentDeckPosition++;
                player.numberOfCards++;
                ai.cards[card] = myDeck[myCurrentDeckPosition];
                ai.numberOfCards++;
                myCurrentDeckPosition++;
            }
            myTrumpCard = myDeck[myCurrentDeckPosition];
            myCurrentDeckPosition++;
            //myTrumpSuit = myTrumpCard.GetSuit();
        }

        public void GetCardImages()
        {
            //Im sure theres a better way to do this but i'll figure it out later
            cardImages[0] = Durak_Group3.Properties.Resources.Card1;
            cardImages[1] = Durak_Group3.Properties.Resources.Card2;
            cardImages[2] = Durak_Group3.Properties.Resources.Card3;
            cardImages[3] = Durak_Group3.Properties.Resources.Card4;
            cardImages[4] = Durak_Group3.Properties.Resources.Card5;
            cardImages[5] = Durak_Group3.Properties.Resources.Card6;
            cardImages[6] = Durak_Group3.Properties.Resources.Card7;
            cardImages[7] = Durak_Group3.Properties.Resources.Card8;
            cardImages[8] = Durak_Group3.Properties.Resources.Card9;
            cardImages[9] = Durak_Group3.Properties.Resources.Card10;
            cardImages[10] = Durak_Group3.Properties.Resources.Card11;
            cardImages[11] = Durak_Group3.Properties.Resources.Card12;
            cardImages[12] = Durak_Group3.Properties.Resources.Card13;
            cardImages[13] = Durak_Group3.Properties.Resources.Card14;
            cardImages[14] = Durak_Group3.Properties.Resources.Card15;
            cardImages[15] = Durak_Group3.Properties.Resources.Card16;
            cardImages[16] = Durak_Group3.Properties.Resources.Card17;
            cardImages[17] = Durak_Group3.Properties.Resources.Card18;
            cardImages[18] = Durak_Group3.Properties.Resources.Card19;
            cardImages[19] = Durak_Group3.Properties.Resources.Card20;
            cardImages[20] = Durak_Group3.Properties.Resources.Card21;
            cardImages[21] = Durak_Group3.Properties.Resources.Card22;
            cardImages[22] = Durak_Group3.Properties.Resources.Card23;
            cardImages[23] = Durak_Group3.Properties.Resources.Card24;
            cardImages[24] = Durak_Group3.Properties.Resources.Card25;
            cardImages[25] = Durak_Group3.Properties.Resources.Card26;
            cardImages[26] = Durak_Group3.Properties.Resources.Card27;
            cardImages[27] = Durak_Group3.Properties.Resources.Card28;
            cardImages[28] = Durak_Group3.Properties.Resources.Card29;
            cardImages[29] = Durak_Group3.Properties.Resources.Card30;
            cardImages[30] = Durak_Group3.Properties.Resources.Card31;
            cardImages[31] = Durak_Group3.Properties.Resources.Card32;
            cardImages[32] = Durak_Group3.Properties.Resources.Card33;
            cardImages[33] = Durak_Group3.Properties.Resources.Card34;
            cardImages[34] = Durak_Group3.Properties.Resources.Card35;
            cardImages[35] = Durak_Group3.Properties.Resources.Card36;
            cardImages[36] = Durak_Group3.Properties.Resources.Card37;
            cardImages[37] = Durak_Group3.Properties.Resources.Card38;
            cardImages[38] = Durak_Group3.Properties.Resources.Card39;
            cardImages[39] = Durak_Group3.Properties.Resources.Card40;
            cardImages[40] = Durak_Group3.Properties.Resources.Card41;
            cardImages[41] = Durak_Group3.Properties.Resources.Card42;
            cardImages[42] = Durak_Group3.Properties.Resources.Card43;
            cardImages[43] = Durak_Group3.Properties.Resources.Card44;
            cardImages[44] = Durak_Group3.Properties.Resources.Card45;
            cardImages[45] = Durak_Group3.Properties.Resources.Card46;
            cardImages[46] = Durak_Group3.Properties.Resources.Card47;
            cardImages[47] = Durak_Group3.Properties.Resources.Card48;
            cardImages[48] = Durak_Group3.Properties.Resources.Card49;
            cardImages[49] = Durak_Group3.Properties.Resources.Card50;
            cardImages[50] = Durak_Group3.Properties.Resources.Card51;
            cardImages[51] = Durak_Group3.Properties.Resources.Card52;
            cardImages[52] = Durak_Group3.Properties.Resources.CardBack;

        }
    }
}
