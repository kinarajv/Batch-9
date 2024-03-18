class GameController 
{
	private IBoard _board;
	private IDice _dice;
	public GameController(IBoard board, IDice dice) 
	{
		_board = board;
		_dice = dice;
	}
}
interface IBoard { }
interface IDice { }
class Board : IBoard { }
class Dice : IDice { }
class UniqueBoard : IBoard { }