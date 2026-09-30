// init
Card card = new Card {suit=Suit.Club, value = 3};
Console.WriteLine(card.suit);
Console.WriteLine(card.value);

// main
Console.WriteLine("fghjkl");

// data types

enum Suit {
  Spade,
  Club,
  Heart,
  Diamond,
};

class Card {
  public Suit suit = Suit.Spade;
  public int  value = 0;
};

