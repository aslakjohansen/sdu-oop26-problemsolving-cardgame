// init
Random rand = new Random();
Card[] cards = new Card[20];
for (int i=0 ; i<cards.Length ; i++) {
  cards[i] = new Card {
    suit  = (Suit) (rand.Next(0, (int) Suit.Length)),
    value = rand.Next(0, 13),
  };
}

foreach (Card card in cards) {
  Console.WriteLine(card.suit);
  Console.WriteLine(card.value);
}

//Card card = new Card {suit=Suit.Club, value = 3};
//Console.WriteLine(card.suit);
//Console.WriteLine(card.value);

// main
//Console.WriteLine("fghjkl");

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

