using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        
        [TestMethod]
        public void AllStrikes()
        {
            Game obj = new Game();
            int result = 0;

            for (int i = 0; i < 12; i++)
                obj.Roll(10);

            result = obj.GetScore();
            Assert.AreEqual(result, 300);
        }

        [TestMethod]
        public void AllZero()
        {
            Game obj = new Game();
            int result = 0;

            for (int i = 0; i < 12; i++)
                obj.Roll(0);

            result = obj.GetScore();
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void NoStrikeNoSpare()
        {
            Game obj = new Game();
            int result = 0;
            
            obj.Roll(0);
            obj.Roll(1);
            obj.Roll(2);
            obj.Roll(3);
            obj.Roll(4);
            obj.Roll(5);
            obj.Roll(0);
            obj.Roll(1);
            obj.Roll(2);
            obj.Roll(3);
            obj.Roll(4);
            obj.Roll(5);
            obj.Roll(0);
            obj.Roll(1);
            obj.Roll(2);
            obj.Roll(3);
            obj.Roll(4);
            obj.Roll(5);
            obj.Roll(0);
            obj.Roll(1);

            result = obj.GetScore();
            Assert.AreEqual(result, 16);
        }

         [TestMethod]
          public void StrikeAtEnd()
          {
              Game obj = new Game();
              int result = 0;

              obj.Roll(4);
              obj.Roll(1);
              obj.Roll(2);
              obj.Roll(3);
              obj.Roll(4);
              obj.Roll(5);
              obj.Roll(1);
              obj.Roll(2);
              obj.Roll(3);
              obj.Roll(4);
              obj.Roll(5);
              obj.Roll(0);
              obj.Roll(1);
              obj.Roll(2);
              obj.Roll(3);
              obj.Roll(4);
              obj.Roll(1);
              obj.Roll(3);
              obj.Roll(10);
              obj.Roll(5);
              obj.Roll(4);

              result = obj.GetScore();
              Assert.AreEqual(result, 67);
          }


         [TestMethod]
         public void Random1()
         {
             Game obj = new Game();
             int result = 0;

             obj.Roll(0);
             obj.Roll(7);
             obj.Roll(9);
             obj.Roll(1);
             obj.Roll(0);
             obj.Roll(6);
             obj.Roll(0);
             obj.Roll(0);
             obj.Roll(0);
             obj.Roll(10);

             result = obj.GetScore();
             Assert.AreEqual(result, 33);
         }

         [TestMethod]
         public void Random2()
         {
             Game obj = new Game();
             int result = 0;

             obj.Roll(0);
             obj.Roll(1);
             obj.Roll(2);
             obj.Roll(3);
             obj.Roll(4);
             obj.Roll(6);

             result = obj.GetScore();
             Assert.AreEqual(result, 16);
         }
    }
}
