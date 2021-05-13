
using System;

namespace Chess
{
    public abstract class ChessFigure
    {
        protected string _currentCoord;

		protected ChessFigure (string currentCoord)
        {
            this._currentCoord = currentCoord;
        }

		internal bool Move (string nextCoord)
		{
			if (!IsValidCoordinates( nextCoord ))
				return false;
			return CheckMove( nextCoord );
		}

		protected abstract bool CheckMove (string nextCoord);

		protected static bool IsValidCoordinates (string coords)
		{
			return coords[0] >= 'A' && coords[0] <= 'H' && coords[1] >= '1' && coords[1] <= '8';
		}
	}

	class PawnFigure : ChessFigure
	{
		public PawnFigure (string currentCoord) : base( currentCoord )
		{
		}
		protected override bool CheckMove (string nextCoord)
		{
			if (nextCoord[0] != _currentCoord[0] || nextCoord[1] <= _currentCoord[1])
				return false;
			if (nextCoord[1] - _currentCoord[1] != 1 && (_currentCoord[1] != '2' || nextCoord[1] != '4'))
				return false;

			return true;
		}
	}

	class RookFigure : ChessFigure
	{
		public RookFigure (string currentCoord) : base( currentCoord ) { 
		}

		protected override bool CheckMove (string nextCoord)
		{
			FigureMove figureMove = new FigureMove( nextCoord, _currentCoord );
			return figureMove.IsValidDirectMove();
		}
	}

	class KnightFigure : ChessFigure
	{
		public KnightFigure (string currentCoord) : base( currentCoord )
		{
		}
		protected override bool CheckMove (string nextCoord)
		{
			FigureMove figureMove = new FigureMove( nextCoord, _currentCoord );
			return figureMove.Dx == 1 && figureMove.Dy == 2 || figureMove.Dx == 2 && figureMove.Dy == 1;
		}
	}

	class BishopFigure : ChessFigure
	{
		public BishopFigure (string currentCoord) : base( currentCoord )
		{
		}
		protected override bool CheckMove (string nextCoord)
		{
			FigureMove figureMove = new FigureMove( nextCoord, _currentCoord );
			return figureMove.IsValidDiagonalMove();
		}
	}

	class QueenFigure : ChessFigure
	{
		public QueenFigure (string currentCoord) : base( currentCoord )
		{
		}
		protected override bool CheckMove (string nextCoord)
		{
			FigureMove figureMove = new FigureMove( nextCoord, _currentCoord );
			return figureMove.IsValidDiagonalMove() || figureMove.IsValidDirectMove();
		}
	}

	class KingFigure : ChessFigure
	{
		public KingFigure (string currentCoord) : base( currentCoord )
		{
		}
		protected override bool CheckMove (string nextCoord)
		{
			FigureMove figureMove = new FigureMove( nextCoord, _currentCoord );
			return figureMove.Dx <= 1 && figureMove.Dy <= 1;
		}
	}
}
