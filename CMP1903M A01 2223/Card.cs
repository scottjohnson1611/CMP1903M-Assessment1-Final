using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        
        
        public int Value { get; set; }
        public int Suit { get; set; }



        public Card(int sub_value, int sub_suit)
        {
            
            
            if (sub_value < 1 || sub_value > 13 )
            {

                Console.WriteLine("Value out of range");


            }
             


            if (sub_suit < 1 || sub_suit > 4)
            {

                Console.WriteLine("Value out of range");

            }




            Value = sub_value;
            Suit = sub_suit;




        }
    }
}
