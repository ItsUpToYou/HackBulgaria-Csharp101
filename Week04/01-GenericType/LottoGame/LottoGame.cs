using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGame
{
    public class LottoGame<T, U>
    {
        private Combination<T, U> winningCombination;

        List<Combination<T, U>> addedComb = new List<Combination<T, U>>();

        //Constructor
        public LottoGame(Combination<T, U> winningComb)
        {
            winningCombination = winningComb;
        }

        public LottoResult AddUserCombination(Combination<T, U> comb)
        {
            bool exist = ValidateCombination(comb);
            LottoResult lotoRes = new LottoResult();

            if (!exist)
            {
                addedComb.Add(comb);
            }
            else
            {
                Console.WriteLine("This combination exist");
            }

            if (winningCombination.Elem1.Equals(comb.Elem1))
                lotoRes.MatchedNumbersCount++;

            if (winningCombination.Elem2.Equals(comb.Elem2))
                lotoRes.MatchedNumbersCount++;

            if (winningCombination.Elem3.Equals(comb.Elem3))
                lotoRes.MatchedNumbersCount++;

            if (winningCombination.Elem4.Equals(comb.Elem4))
                lotoRes.MatchedNumbersCount++;

            if (winningCombination.Elem5.Equals(comb.Elem5))
                lotoRes.MatchedNumbersCount++;

            if (winningCombination.Elem6.Equals(comb.Elem6))
                lotoRes.MatchedNumbersCount++;

            if (lotoRes.MatchedNumbersCount >= 3)
            {
                lotoRes.IsWinning = true;
            }

            return lotoRes;
        }

        private bool ValidateCombination(Combination<T, U> newAdd)
        {
            return addedComb.Contains(newAdd);
        }

        private Combination<T, U> GetWining()
        {
            return winningCombination;
        }
    }

    public class LottoResult
    {
        public bool IsWinning { get; set; }
        public byte MatchedNumbersCount { get; set; }
    }
}
