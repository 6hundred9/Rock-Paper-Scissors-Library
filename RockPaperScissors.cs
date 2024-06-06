namespace RockPaperScissors;

public class RockPaperScissors
{
    /// <summary>
    /// Decides who won the game of Rock Paper Scissors
    /// </summary>
    /// <param name="player1">What the action of player 1 was</param>
    /// <param name="player2">What the action of player 2 was</param>
    /// <returns>Draw, Win or Lose from the perspective of player 1</returns>
    public static State Play(Rps player1, Rps player2)
    {
        if (player1 == player2)
        {
            return State.Draw;
        }
        if (player1 == Rps.Rock && player2 == Rps.Scissors ||
                 player1 == Rps.Paper && player2 == Rps.Rock ||
                 player1 == Rps.Scissors && player2 == Rps.Paper)
        {
            return State.Win;
        }

        return State.Lose;
    }
}