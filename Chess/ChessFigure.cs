
using System;

namespace Chess
{
    public abstract class ChessFigure
    {
        protected string currentCoord;

		protected ChessFigure (string currentCoord)
        {
            this.currentCoord = currentCoord;
        }

		internal abstract bool Move (string nextCoord);
    }

	class PawnFigure : ChessFigure
	{
		public PawnFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
			{
				if (nextCoord[0] != currentCoord[0] || nextCoord[1] <= currentCoord[1] || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' || nextCoord[1] != '4')))
					return false;
				else
					return true;
			}
			return false;
		}
	}

	class RookFigure : ChessFigure
	{
		public RookFigure (string currentCoord) : base( currentCoord ) { 
		}

		internal override bool Move (string nextCoord)
		{
			if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
			{
				if ((nextCoord[0] != currentCoord[0]) && (nextCoord[1] != currentCoord[1]) || ((nextCoord[0] == currentCoord[0]) && (nextCoord[1] == currentCoord[1])))
					return false;
				else
					return true;

			}
			return false;
		}
	}

	class KnightFigure : ChessFigure
	{
		public KnightFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
			{
				int dx, dy;
				dx = Math.Abs( nextCoord[0] - currentCoord[0] );
				dy = Math.Abs( nextCoord[1] - currentCoord[1] );
				if (!(Math.Abs( nextCoord[0] - currentCoord[0] ) == 1 && Math.Abs( nextCoord[1] - currentCoord[1] ) == 2 || Math.Abs( nextCoord[0] - currentCoord[0] ) == 2 && Math.Abs( nextCoord[1] - currentCoord[1] ) == 1))
					return false;
				else
					return true;
			}
			return false;
		}
	}
	class BishopFigure : ChessFigure
	{
		public BishopFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
			{
				if (!(Math.Abs( nextCoord[0] - currentCoord[0] ) == Math.Abs( nextCoord[1] - currentCoord[1] )))
					return false;
				else
					return true;
			}
			return false;
		}
	}
	class QueenFigure : ChessFigure
	{
		public QueenFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
			{
				if (!(Math.Abs( nextCoord[0] - currentCoord[0] ) == Math.Abs( nextCoord[1] - currentCoord[1] ) || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1]))
					return false;
				else
					return true;
			}
			return false;
		}
	}
	class KingFigure : ChessFigure
	{
		public KingFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
			{
				return (Math.Abs( nextCoord[0] - currentCoord[0] ) <= 1 && Math.Abs( nextCoord[1] - currentCoord[1] ) <= 1);
			}
			return false;
		}
	}
}
