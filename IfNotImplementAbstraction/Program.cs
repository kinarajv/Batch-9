class MonopolyGameController{
	private FreeJailCard[] _freeJailCards;
	private BirthdayCard[] _birthdayCards;
	private FreeParkCard[] _freeParkCards;
	private JailCard[] _jailCards;
	private int _freeJailCardsCount = 0;
	private int _birthdayCardsCount = 0;
	private int _freeParkCardsCardsCount = 0;
	private int _jailCardsCount = 0;
	public MonopolyGameController(int card) {
		_freeJailCards = new FreeJailCard[card];
		_jailCards = new JailCard[card];
		_birthdayCards = new BirthdayCard[card];
		_freeParkCards = new FreeParkCard[card];
	}
	public bool AddBirthdayCard(BirthdayCard card) {
		_birthdayCards[_birthdayCardsCount] = card;
		_birthdayCardsCount++;
		return true;
	}
	public bool AddJailCard(JailCard card) {
		_jailCards[_jailCardsCount] = card;
		_jailCardsCount++;
		return true;
	}
}

class BirthdayCard {
	private int _id;
	private string _name;
	private string _colour;
	public int GetId() {
		return _id;
	}
	public string GetName() {
		return _name;
	}
	public string GetColour() {
		return _colour;
	}
	public BirthdayCard(int id, string name, string colour) {
	
	}
	public void StartEffect() {
		Console.WriteLine("Birthday card effect starting...");
	}
}
class FreeParkCard {
	private int _id;
	private string _name;
	private string _colour;
	public FreeParkCard(int id, string name, string colour) {
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
	public void StartEffect() {
		Console.WriteLine("FreeParkCard effect starting...");
	}
}
class JailCard  {
	private int _id;
	private string _name;
	private string _colour;
	public int GetId() {
		return _id;
	}
	public string GetName() {
		return _name;
	}
	public string GetColour() {
		return _colour;
	}
	public void StartEffect() {
		Console.WriteLine("JailCard effect starting...");
	}
}
class FreeJailCard {
	private int _id;
	private string _name;
	private string _colour;
	public int GetId() {
		return _id;
	}
	public string GetName() {
		return _name;
	}
	public string GetColour() {
		return _colour;
	}
	public void StartEffect() {
		Console.WriteLine("FreeJailCard effect starting...");
	}
}