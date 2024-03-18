namespace GameControllerLib;

public class GameController
{
	private Dictionary<IPlayer, HashSet<ICard>> _players;
	private IBoard _board;
	public event Action<ICard>? OnCardUpdate;

	public GameController(IPlayer player, IBoard board)
	{
		_players = new()
			{
				{ player, new HashSet<ICard>()}
			};
		_board = board;
		//log.Info("GameController created");
	}

	public bool AddCards(IPlayer player, params ICard[] cards)
	{
		if (!_players.TryGetValue(player, out HashSet<ICard>? playerCards))
		{
			return false;
		}
		foreach (var card in cards)
		{
			playerCards.Add(card);
			ChangeCardStatus(card, CardStatus.OnPlayer);
		}
		return true;
	}

	public IEnumerable<ICard> GetCards(IPlayer player)
	{
		if (!_players.ContainsKey(player))
		{
			return Enumerable.Empty<ICard>();
		}

		return _players[player];
	}

	public bool RemoveCard(IPlayer player, ICard card)
	{
		if (!_players.ContainsKey(player))
		{
			return false;
		}

		if (!_players[player].Contains(card))
		{
			return false;
		}
		_players[player].Remove(card);
		ChangeCardStatus(card, CardStatus.Removed);
		return true;
	}

	public void ChangeCardStatus(ICard card, CardStatus status)
	{
		card.SetStatus(status);
		OnCardUpdate?.Invoke(card);
	}
}
