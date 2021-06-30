using System;
using Xunit;

namespace SA_Lotto.Test
{
    public class TestSALotto
    {
        [Fact]
        public void TestWinnerDivision1()
        {
            //Arrange
            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            //Act 
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);

            var drawResults = lotto_instance.GetDivision(5, 10, 11, 8, 25, 15);
            //Assert
            Assert.Equal("Winner - Division1", drawResults.Result);

        }

        [Fact]
        public void TestWinnerDivision2()
        {
            //Arrange
            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            //Act 
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);

            var drawResults = lotto_instance.GetDivision(5, 10, 11, 8, 25, 45);
            //Assert
            Assert.Equal("Winner - Division2", drawResults.Result);

        }

        [Fact]
        public void TestWinnerDivision3()
        {
            //Arrange
            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            //Act 
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);

            var drawResults = lotto_instance.GetDivision(5, 10, 11, 8, 25, 7);
            //Assert
            Assert.Equal("Winner - Division3", drawResults.Result);

        }

        [Fact]
        public void TestWinnerDivision4()
        {
            //Arrange
            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            //Act 
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);

            var drawResults = lotto_instance.GetDivision(5, 10, 11, 8, 45, 7);
            //Assert
            Assert.Equal("Winner - Division4", drawResults.Result);

        }

        [Fact]
        public void TestWinnerDivision5()
        {
            //Arrange
            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            //Act 
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);

            var drawResults = lotto_instance.GetDivision(5, 10, 11, 8, 9, 7);
            //Assert
            Assert.Equal("Winner - Division5", drawResults.Result);

        }

        [Fact]
        public void TestWinnerDivision6()
        {
            //Arrange

            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            // Act
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);
            var drawResults = lotto_instance.GetDivision(10, 25, 17, 8, 36, 45);

            //Assert
            Assert.Equal("Winner - Division6", drawResults.Result);
        }
        [Fact]
        public void TestWinnerDivision8()
        {
            //Arrange

            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            // Act
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);
            var drawResults = lotto_instance.GetDivision(10, 25, 17, 2, 36, 45);

            //Assert
            Assert.Equal("Winner - Division8", drawResults.Result);
        }

        [Fact]
        public void TestWinnerDivision7()
        {
            //Arrange

            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            // Act
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);
            var drawResults = lotto_instance.GetDivision(10, 25, 17, 8, 36, 40);

            //Assert
            Assert.Equal("Winner - Division7", drawResults.Result);
        }
        [Fact]
        public void TestLoss()
        {
            //Arrange
            var lotto_instance = GameFactory.GetInstance("SA Lotto", new DateTime(2018, 06, 06));

            //Act 
            lotto_instance.CaptureDraw(5, 10, 11, 25, 15, 8, 45);

            var drawResults = lotto_instance.GetDivision(2, 10, 1, 3, 9, 7);
            //Assert
            Assert.Equal("Not a winner", drawResults.Result);
        }
    }
}
