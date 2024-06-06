namespace RockPaperScissors.Extensions;

public static class RandomExtensions
{
    /// <summary>
    /// Returns a random enum value
    /// </summary>
    /// <param name="random">Random extension</param>
    /// <typeparam name="T">The enum you want to get the value from</typeparam>
    /// <returns>Random enum</returns>
    public static T NextEnum<T>(this Random random)
        where T : struct, Enum
    {
        var values = Enum.GetValues<T>();

        return values[random.Next(values.Length)];
    }
}