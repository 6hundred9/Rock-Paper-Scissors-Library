using RockPaperScissors.Extensions;

namespace RockPaperScissors;

public class RockPaperScissors
{

    /// <summary>
    /// Decides who won the game of Rock Paper Scissors using <see cref="Choice"/>
    /// </summary>
    /// <param name="player1">What the <see cref="Choice"/>> of player 1 was</param>
    /// <param name="player2">What the <see cref="Choice"/>> of player 2 was</param>
    /// <returns>Draw, Win or Lose from the perspective of player 1</returns>
    public static State Play(Choice player1, Choice player2)
    {
        if (player1 == player2)
        {
            return State.Draw;
        }
        
        if ((player1 == Choice.Rock && player2 == Choice.Scissors) ||
            (player1 == Choice.Paper && player2 == Choice.Rock) ||
            (player1 == Choice.Scissors && player2 == Choice.Paper))
        {
            return State.Player1;
        }
        return State.Player2;
    }
    /// <summary>
    /// Decides who won the game of Rock Paper Scissors using integers
    /// </summary>
    /// <param name="player1">What the action of player 1 was (0 = Rock, 1 = Paper, 2 = Scissors)</param>
    /// <param name="player2">What the action of player 2 was (0 = Rock, 1 = Paper, 2 = Scissors)</param>
    /// <returns>Draw, Win or Lose from the perspective of player 1</returns>
    public static State Play(int player1, int player2)
    {
        if (player1 == player2)
        {
            return State.Draw;
        }
        
        if ((player1 == 0 && player2 == 2) ||
            (player1 == 1 && player2 == 0) ||
            (player1 == 2 && player2 == 1))
        {
            return State.Player1;
        }
        return State.Player2;
    }
    /// <summary>
    /// Chooses a random choice between rock, paper and scissors
    /// </summary>
    /// <returns>Random value</returns>
    public static Choice ChooseRandom()
    {
        return new Random().NextEnum<Choice>();
    }
}