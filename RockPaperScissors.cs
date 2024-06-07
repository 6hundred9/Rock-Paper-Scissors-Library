using System.Collections;
using System.Diagnostics.CodeAnalysis;
using RockPaperScissors.Extensions;

namespace RockPaperScissors;

public class RockPaperScissors
{
    public static int Player1Score { get; private set; }
    public static int Player2Score { get; private set; }
    /// <summary>
    /// Decides who won the game of Rock Paper Scissors using <see cref="Choice"/>
    /// </summary>
    /// <param name="player1">What the <see cref="Choice"/>> of player 1 was</param>
    /// <param name="player2">What the <see cref="Choice"/>> of player 2 was</param>
    /// <returns>Draw, Win or Lose from the perspective of player 1</returns>
    public static State Play(Choice player1, Choice player2)
    {
        if (player1 == null || player2 == null)
        {
            throw new ArgumentNullException("Player choice cannot be null");
        }
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
        if (player1 > 2 || player1 < 0 || player2 > 2 || player2 < 0)
        {
            throw new ArgumentOutOfRangeException("Player choice must be between 0 and 2 (including 2)");
        }
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
    /// <summary>
    /// Turns integer into <see cref="Choice"/>
    /// </summary>
    /// <param name="choice">the integer for choice</param>
    /// <returns>the <see cref="Choice"/></returns>
    public static Choice IntToChoice(int choice)
    {
        return (Choice)choice;
    }
    /// <summary>
    /// Turns <see cref="Choice"/> into integer
    /// </summary>
    /// <param name="choice">The choice for integer conversion</param>
    /// <returns>The integer</returns>
    public static int ChoiceToInt(Choice choice)
    {
        return (int)choice;
    }

    /// <summary>
    /// Starts a game of rock paper scissors
    /// </summary>
    /// <param name="player1">What player 1 choose (doesn't have to be used if player1IsHuman is false)</param>
    /// <param name="player2">What player 1 choose (doesn't have to be used if player1IsHuman is false)</param>
    /// <param name="loops">(false if null) Whether the game loops or not (false for one-time gameplay)</param>
    /// <param name="player1IsHuman">If false, player 1's choice will be randomized</param>
    /// <param name="player2IsHuman">If false, player 2's choice will be randomized</param>
    /// <returns>In order: Player 1 score, player 2 score, player 1 choice, player 2 choice, game state (player1, player2, draw)</returns>
    public static List<object> Main(Choice? player1, Choice? player2, bool? loops,  bool player1IsHuman = true, bool player2IsHuman = false)
    {
        Choice p1 = ChooseRandom();
        Choice p2 = ChooseRandom();
        if (!player1IsHuman) p1 = ChooseRandom();
        else if (player1 != null) p1 = player1.Value;
        if (!player2IsHuman) p2 = ChooseRandom();
        else if (player2 != null) p2 = player2.Value;
        State state;
        if (loops.HasValue && loops.Value)
        {
            for (;;)
            {
                p1 = !player1IsHuman ? ChooseRandom() : player1.Value;
                p2 = !player2IsHuman ? ChooseRandom() : player2.Value;
                state = Play(p1, p2);
                if (state == State.Player1) Player1Score++;
                else if (state == State.Player2) Player2Score++;
                return new() { Player1Score, Player2Score, p1, p2, state };
            }
        }
        state = Play(p1, p2);
        if (state == State.Player1) Player1Score++;
        else if (state == State.Player2) Player2Score++;

        return new() { Player1Score, Player2Score, p1, p2, state };
    }
}