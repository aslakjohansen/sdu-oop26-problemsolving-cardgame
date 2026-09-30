// init

Random rand = new Random();
Card[] cards = new Card[20];
for (int i=0 ; i<cards.Length ; i++) {
  cards[i] = new Card {
    suit  = (Suit) (rand.Next(0, (int) Suit.Length)),
    value = rand.Next(0, 13),
  };
}

// main

// data types

enum Suit {
  Spade,
  Club,
  Heart,
  Diamond,
  Length,
};

class Card {
  public Suit suit = Suit.Spade;
  public int  value = 0;
};

