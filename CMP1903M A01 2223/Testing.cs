using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public static void test_mode()
        {
            Pack pack = new Pack();
            List<Card> Card_test = new List<Card>();

            //Onecard deal test
            
            Pack.shuffleCardPack(1);
            Card oneDealt = Pack.deal();


            Console.WriteLine("One deal, Suit:", oneDealt.Suit, "Value:", oneDealt.Value, "Shuffle Type: Fisher-Yates");

            Pack.shuff_pack.Clear();



            Pack.shuffleCardPack(2);
            Card oneDealt2 = Pack.deal();


            Console.WriteLine("One deal, Suit:", oneDealt2.Suit, "Value:", oneDealt2.Value, "Shuffle Type: Ripple");


            Pack.shuff_pack.Clear();

            Pack.shuffleCardPack(3);
            Card oneDealt3 = Pack.deal();


            Console.WriteLine("One deal, Suit:", oneDealt3.Suit, "Value:", oneDealt3.Value, "Shuffle Type: None");


            Pack.shuff_pack.Clear();

            //Multicard deal test


            List<Card> card_deck = new List<Card>();

            Pack.shuffleCardPack(1);
            card_deck = Pack.dealCard(5);

            foreach (Card card in card_deck)//Cycles throughh each element dealt
            {
                Console.WriteLine("Multi deal, Suit:", card.Suit, "Value:", card.Value, "Shuffle Type: Fisher-Yates");
            }

            Pack.shuff_pack.Clear();

            Pack.shuffleCardPack(2);
            card_deck = Pack.dealCard(5);

            foreach (Card card in card_deck)
            {
                Console.WriteLine("Multi deal, Suit:", card.Suit, "Value:", card.Value, "Shuffle Type: Ripple");
            }

            Pack.shuff_pack.Clear();

            Pack.shuffleCardPack(3);
            card_deck = Pack.dealCard(5);

            foreach (Card card in card_deck)
            {
                Console.WriteLine("Multi deal, Suit:", card.Suit, "Value:", card.Value, "Shuffle Type: None");
            }

        }





    }




}

