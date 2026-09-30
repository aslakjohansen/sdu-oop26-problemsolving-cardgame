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
for (int s=0 ; s<(int)Suit.Length ; s++) {
  Suit suit = (Suit) s;
  
  int largest = -1;
  foreach (Card card in cards) {
    // guard: reject wrong suit
    if (card.suit != suit) continue;
    
    if (card.value>largest) {
      largest = card.value;
    }
  }
  
  Console.WriteLine("Largest value for "+suit+" is "+largest);
}

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

