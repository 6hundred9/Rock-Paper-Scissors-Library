# Rock-Paper-Scissors-Library
A Simple NuGet library for rock paper scissors

### Documentation
##### Choice Enums
The [Choice Enums](Choice.cs) are used for what each player chooses
##### State Enums
The [State Enums](State.cs) are used to determine if player 1 lost, won, or finished with a draw
##### Play Method
Definition 1: `public static State Play(Choice player1, Choice player2)`

Arguements:
* Player 1: The [input](Choice.cs) of player 1
* Player 2: The [input](Choice.cs) of player 2

* Returns: Which player won or if it was a draw from [these](State.cs)

Definition 2: `public static State Play(int player1, int player2)`

Arguments:
* Player 1: The integer of player 1 (Rock = 0, Paper = 1, Scissors = 2)
* Player 2: The integer of player 2 (Rock = 0, Paper = 1, Scissors = 2)

Returns: Which player won or if it was a draw from [these](State.cs)

##### ChooseRandom Method
Definition:`public static Choice ChooseRandom()`

Arguments: None

Returns: A random [choice](Choice.cs)

##### IntToChoice Method
Definition:`public static Choice IntToChoice(int choice)`

Arguments: An integer

Returns: The [choice](Choice.cs)

##### ChoiceToInt Method
Definition: `public static int ChoiceToInt(Choice choice)`

Arguments: A [choice](Choice.cs)

Returns: The integer of the [choice](Choice.cs)
##### Main Method
Definition: `public static List<object> Main(Choice? player1, Choice? player2, bool player1IsHuman = true, bool player2IsHuman = false)`

Arguements:
* player1: What the choice of player 1 was, not used if player1IsHuman is false, random if null.
* player2: What the choice of player 2 was, not used if player2IsHuman is false, random if null
* player1IsHuman: Whether player 1 input will be randomized or not
* player2IsHuman: Whether player 2 input will be randomized or not

Returns:
* Element 0: Player 1 score
* Element 1: Player 2 score
* Element 2: Player 1 choice
* Element 3: Player 2 choice
* Element 4: State (Player 1 win, player 2 win, draw)
## Extension Methods
### Random Extensions
##### NextEnum Method
Definition: `public static T NextEnum<T>(this Random random)`
Arguments: Random Extension
Returns: A random enum value