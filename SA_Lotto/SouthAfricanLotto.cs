using System;
using System.Collections.Generic;
using SA_Lotto.Models;

namespace SA_Lotto
{
    public class SouthAfricanLotto : LottoBase
    {
        private List<CapturedNumberModel> capturedNumbers;
        public SouthAfricanLotto(string gameType, DateTime drawDate) : base(gameType, drawDate)
        {

        }

        public override void CaptureDraw(int number1, int number2, int number3, int number4, int number5, int number6, int number7)
        {
            capturedNumbers = new List<CapturedNumberModel>();
            capturedNumbers.Add(new CapturedNumberModel { Number = number1, IsBonus = false });
            capturedNumbers.Add(new CapturedNumberModel { Number = number2, IsBonus = false });
            capturedNumbers.Add(new CapturedNumberModel { Number = number3, IsBonus = false });
            capturedNumbers.Add(new CapturedNumberModel { Number = number4, IsBonus = false });
            capturedNumbers.Add(new CapturedNumberModel { Number = number5, IsBonus = false });
            capturedNumbers.Add(new CapturedNumberModel { Number = number6, IsBonus = false });
            capturedNumbers.Add(new CapturedNumberModel { Number = number7, IsBonus = true });
        }

        public override DivisionModel GetDivision(int number1, int number2, int number3, int number4, int number5, int number6)
        {
            var totalMatched = 0;
            var isBonusMatched = false;

            var numbers = new List<int>()
            {
                number1, number2 , number3 , number4 , number5 , number6
            };

            capturedNumbers.ForEach(x =>
            {
                numbers.ForEach(n =>
               {
                   if (x.Number == n)
                   {
                       if (x.IsBonus == true)
                       {
                           isBonusMatched = true;
                       }

                       totalMatched++;
                      
                   }
               }); 
            });

            if (isBonusMatched)
            {
                totalMatched -= 1;
            }

            var divisionModel = BuildDrawResults(totalMatched, isBonusMatched);

            var results = divisionModel.Division.HasValue ? $"{divisionModel.Result} - {divisionModel.Division.Value}" : divisionModel.Result;

            return new DivisionModel
            {
                Result = results
            };
        }

        public DivisionModel BuildDrawResults(int totalMatched , bool isBonusMatched)
        {
            if (totalMatched == 2 && isBonusMatched == true)
            {
                return new DivisionModel { Division = Division.Division8, Result = "Winner" };
            }
            else if (totalMatched == 3 && !isBonusMatched)
            {
                return new DivisionModel { Division = Division.Division7, Result = "Winner" };
            }
            else if(totalMatched == 3 && isBonusMatched == true)
            {
                return new DivisionModel { Division = Division.Division6, Result = "Winner" };
            }
            else if(totalMatched == 4 && !isBonusMatched)
            {
                return new DivisionModel { Division = Division.Division5 , Result = "Winner" };
            }
            else if(totalMatched == 4 && isBonusMatched)
            {
                return new DivisionModel { Division = Division.Division4, Result = "Winner" };
            }
            else if(totalMatched == 5 && !isBonusMatched)
            {
                return new DivisionModel { Division = Division.Division3, Result = "Winner" };
            }
            else if(totalMatched == 5 &&  isBonusMatched == true)
            {
                return new DivisionModel { Division = Division.Division2, Result = "Winner" };
            }
            else if(totalMatched == 6)
            {
                return new DivisionModel { Division = Division.Division1, Result = "Winner" };
            }

            return new DivisionModel { Result = "Not a winner" };
        }

    }
}
