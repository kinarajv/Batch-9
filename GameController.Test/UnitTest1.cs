using GameControllerLib;
using Moq;
namespace GameControllerTest;

public class GameControllerTests
{
	private GameController _game;
	private Mock<IPlayer> _player;
	private Mock<IBoard> _board;
	[SetUp]
	public void Setup()
	{
		_player = new Mock<IPlayer>();
		_board = new Mock<IBoard>();
		_game = new(_player.Object, _board.Object);
	}

	[Test] 
	//Positive Testing
	//Method_ExpectedBehavior_StateUnderTest
	public void AddCards_CardsAdded_PlayerExists()
	{
		//Arrange
		Mock<ICard> card = new Mock<ICard>();
		//Act
		bool result = _game.AddCards(_player.Object, card.Object);
		//Assert
		Assert.IsTrue(result);
		card.Verify(card => card.SetStatus(CardStatus.OnPlayer), Times.Never);
	}
	
	[Test] 
	//Positive Testing
	//Method_ExpectedBehavior_StateUnderTest
	public void AddCards_ReturnsFalse_PlayerNotExist()
	{
		//Arrange
		Mock<ICard> card = new Mock<ICard>();
		Mock<IPlayer> newPlayer = new Mock<IPlayer>();
		//Act
		bool result = _game.AddCards(newPlayer.Object, card.Object);
		//Assert
		Assert.IsFalse(result);
		card.Verify(card => card.SetStatus(It.IsAny<CardStatus>()), Times.Never);
	}
}