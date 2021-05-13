// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chess
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void RookShouldBeCorrectMove()
        {
            ChessFigure figure = new RookFigure( "E2" );
            Assert.AreEqual(true,figure.Move("C2"));
        }
        [Test]
        public void RookShouldBeIncorrectMove()
        {
            ChessFigure figure = new RookFigure( "E2" );
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void KnightShouldBeCorrectMove()
        {
            ChessFigure figure = new KnightFigure( "B1" );
            Assert.AreEqual(true,figure.Move("C3"));
        }
        [Test]
        public void KnightShouldBeIncorrectMove()
        {
            ChessFigure figure = new KnightFigure( "B1" );
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void BishopShouldBeCorrectMove()
        {
            ChessFigure figure = new BishopFigure( "C1" );
            Assert.AreEqual(true,figure.Move("E3"));
        }
        [Test]
        public void BishopShouldBeIncorrectMove()
        {
            ChessFigure figure = new BishopFigure( "C1" );
            Assert.AreEqual(false,figure.Move("C3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove0()
        {
            ChessFigure figure = new PawnFigure( "E2" );
            Assert.AreEqual(true,figure.Move("E3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove1()
        {
            ChessFigure figure = new PawnFigure( "E2" );
            Assert.AreEqual(true,figure.Move("E4"));
        }
        [Test]
        public void PawnShouldBeCorrectMove2()
        {
            ChessFigure figure = new PawnFigure( "E4" );
            Assert.AreEqual(true,figure.Move("E5"));
        }   
        [Test]
        public void PawnShouldBeIncorrectMove()
        {
            ChessFigure figure = new PawnFigure( "E2" );
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void KingShouldBeCorrectMove()
        {
            ChessFigure figure = new KingFigure( "E1" );
            Assert.AreEqual(true,figure.Move("E2"));
        }
        [Test]
        public void KingShouldBeIncorrectMove()
        {
            ChessFigure figure = new KingFigure( "E1" );
            Assert.AreEqual(false,figure.Move("E8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveVertical()
        {
            ChessFigure figure = new QueenFigure( "D1" );
            Assert.AreEqual(true,figure.Move("D8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveDiagonal()
        {
            ChessFigure figure = new QueenFigure( "D1" );
            Assert.AreEqual(true,figure.Move("H5"));
        }
        [Test]
        public void QueenShouldBeIncorrectMove()
        {
            ChessFigure figure = new QueenFigure( "D1" );
            Assert.AreEqual(false,figure.Move("E3"));
        }
    }
}
