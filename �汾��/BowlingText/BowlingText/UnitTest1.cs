using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;

namespace BowlingText
{
    
    [TestClass]
    public class UnitTest1
    {
        public UnitTest1()
        {
           
           
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
        
            BowlingBall ball = new BowlingBall();

            turn[] TempTurn=new turn[10] ;
             TempTurn[0].mark = 2;
             TempTurn[0].firstScore = 1;
             TempTurn[0].secondScore = 9;
             ball.Aturn[0] = TempTurn[0];
             ball.Aturn[8] = TempTurn[0];

             TempTurn[1].mark = 2;
             TempTurn[1].firstScore = 2;
             TempTurn[1].secondScore = 8;
             ball.Aturn[1] = TempTurn[1];
             ball.Aturn[7] = TempTurn[1];

             TempTurn[2].mark = 2;
             TempTurn[2].firstScore = 3;
             TempTurn[2].secondScore = 7;
             ball.Aturn[2] = TempTurn[2];
             ball.Aturn[6] = TempTurn[2];

             TempTurn[3].mark = 2;
             TempTurn[3].firstScore = 4;
             TempTurn[3].secondScore = 6;
             ball.Aturn[3] = TempTurn[3];
             ball.Aturn[5] = TempTurn[3];

             TempTurn[4].mark = 2;
             TempTurn[4].firstScore = 5;
             TempTurn[4].secondScore = 5;
             ball.Aturn[4] = TempTurn[4];
             
            
            TempTurn[5].mark = 2;
            TempTurn[5].firstScore = 5;
            TempTurn[5].secondScore = 5;
            TempTurn[5].thirdScore = 5;
            ball.Aturn[9] = TempTurn[5];
           




                Assert.AreEqual(134, ball.SumScore());
        }
    }
}

