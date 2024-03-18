class GameController 
{
	Dictionary<Player, List<ICard>> players;
	public List<ICard> GetPossibleCards(Player p) 
	{
		return players[p];
	}
}
public class Player { }
public interface ICard { }