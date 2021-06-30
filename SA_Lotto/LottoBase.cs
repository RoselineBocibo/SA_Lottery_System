using SA_Lotto.Models;
using System;

namespace SA_Lotto
{
    public abstract class LottoBase
    {
        protected string gameType;
        protected DateTime drawDate;
        public LottoBase(string gameType , DateTime drawDate)
        {
            this.gameType = gameType;
            this.drawDate = drawDate;
        }
        public abstract void CaptureDraw(int number1 , int number2 , int number3 , int number4 , int number5 , int number6 , int number7);
        public abstract DivisionModel GetDivision(int number1, int number2, int number3, int number4, int number5, int number6);
    }
}
