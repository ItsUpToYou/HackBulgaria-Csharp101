using System;

namespace LottoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Combination<int, string> winingCombinaton = new Combination<int, string>(1, 2, 3, "a", "b", "a");
            LottoGame<int, string> startGame = new LottoGame<int, string>(winingCombinaton);
            LottoResult result = startGame.AddUserCombination(new Combination<int, string>(0, 2, 3, "a", "k", "k"));
            Console.WriteLine("{0}, matched combination: {1}", result.IsWinning, result.MatchedNumbersCount);
        }
    }
}
