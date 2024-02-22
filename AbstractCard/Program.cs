class Program 
{
	static void Main() 
	{
		MonopolyGameController monopoly = new(20);
		monopoly.AddCard(new BirthdayCard(1,"birthday","yellow"));
		monopoly.AddCard(new JailCard(2,"jail","red"));
	}
}
class MonopolyGameController{
	private Card[] cards = null;
	private int count = 0;
	public MonopolyGameController(int card) {
		cards = new Card[card];
	}
	public bool AddCard(Card card) {
		if(count == cards.Length-1) 
		{
			return false;
		}
		cards[count] = card;
		count++;
		return true;
	}
	public IEnumerable<Card> GetAllCards() 
	{
		if (cards is null) 
		{
			return Enumerable.Empty<Card>();
		}
		return cards;
	}
}

abstract class Card {
	private int _id;
	private string _name;
	private string _colour;
	public Card(int id, string name, string colour) {
		_id = id;
		_name = name;
		_colour = colour;
	}
	public int GetId() {
		return _id;
	}
	public string GetName() {
		return _name;
	}
	public string GetColour() {
		return _colour;
	}
	public abstract void StartEffect();
}
class BirthdayCard : Card {
	public BirthdayCard(int id, string name, string colour) : base(id, name, colour) {
	
	}
	public override void StartEffect() {
		Console.WriteLine("Birthday card effect starting...");
	}
}
class FreeParkCard : Card {
	public FreeParkCard(int id, string name, string colour) : base(id, name, colour) {
	
	}
	public override void StartEffect() {
		Console.WriteLine("FreeParkCard effect starting...");
	}
}
class JailCard : Card {
	public JailCard(int id, string name, string colour) : base(id, name, colour) {
	
	}
	public override void StartEffect() {
		Console.WriteLine("JailCard effect starting...");
	}
}
class FreeJailCard : Card {
	public FreeJailCard(int id, string name, string colour) : base(id, name, colour) {
	
	}
	public override void StartEffect() {
		Console.WriteLine("FreeJailCard effect starting...");
	}
}