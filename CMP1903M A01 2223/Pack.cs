using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public List<Card> card_pack;
        public static List<Card> shuff_pack = new List<Card>();

        public Pack()
        {

            card_pack = new List<Card>();

            for (int suit = 1; suit < 5; suit++)
            {
                for (int value = 1; value <14; value++)
                {
                    card_pack.Add(new Card(value, suit));
                }
            }

            //adds every card to new deck 
        }

        public static bool shuffleCardPack(int typeOfShuffle) //fisher-yates shuffle
        {
            Pack pack = new Pack();
            int card_count = pack.card_pack.Count;

            if (typeOfShuffle == 1)//simple if for type selection
            {
                Random random = new Random();
                
                for (int i = card_count - 1; i > 0; i--)//loops through pack
                {

                    int rand = random.Next(0, i + 1);//selects random index
                    Card PH = pack.card_pack[rand];//takes that index value as placeholder
                    pack.card_pack[rand] = pack.card_pack[i];//replaces last postion with random 
                    pack.card_pack[i] = PH;//replaces last value with placveholder




                }

                Pack.shuff_pack = pack.card_pack;//adds shuffled deck to new list

                return true;
            }

            if (typeOfShuffle == 2) //ripple shuffle
            {

                List<Card> FrontHalf = new List<Card>();
                List<Card> LastHalf = new List<Card>();

                //create two lists to shuffle from

                for (int i = 0; i > card_count / 2; i++)
                {
                    FrontHalf.Add(pack.card_pack[i]);



                }
                
                //devide pack between the 2 lists

                for (int i = card_count / 2; i < card_count; i++)
                {

                    LastHalf.Add(pack.card_pack[i]);

                }


                for (int i = 0; i < card_count / 2; i++)
                {

                    shuff_pack.Add(FrontHalf[i]);
                    shuff_pack.Add(LastHalf[i]);
                 
                               

                }

                //combine packs alternatly to produce suffled pack









                return true;

            }
            if (typeOfShuffle == 3) //no shuffle
            {

                Pack.shuff_pack = pack.card_pack; //passes unshuffled pack to shuffled pack list
                return true;

            }


            //Shuffles the pack based on the type of shuffle
            return true;
        }
        public static Card deal()
        {

            Card card_value = Pack.shuff_pack[0];

            return card_value;
            
            //Deals one card
            
        }
        public static List<Card> dealCard(int amount)
        {

            List<Card> card_value = new List<Card>();

            for (int i = 0; i < amount; i++)// deals cards dependent on amount specified 
            {

                card_value.Add(Pack.shuff_pack[i]);

            }

            return card_value;
            
           
            
            //Deals the number of cards specified by 'amount'
        }
    }
}
