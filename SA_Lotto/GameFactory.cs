using System;
using System.Collections.Generic;
using System.Text;

namespace SA_Lotto
{
    public static class GameFactory
    {
        public static LottoBase GetInstance(string gameType , DateTime drawDate)
        {
            if (gameType == null && drawDate == null)
            {
                return null;
            }
            else if (gameType == "SA Lotto" && drawDate != null)
            {
                return new SouthAfricanLotto(gameType, drawDate);
            }

            return null;
        }
    }
}
