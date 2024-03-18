class GameController 
{
	Dictionary<Player, List<ICard>> players;
	public void GetPossibleCards(Player p) 
	{
		foreach(ICard card in players[p]) 
		{
			Console.WriteLine(card);
		}
	}
}
public class Player { }
public interface ICard { }