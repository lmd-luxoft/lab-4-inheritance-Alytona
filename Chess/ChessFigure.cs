
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

		protected static bool IsValidCoordinates (string coords)
		{
			return coords[0] >= 'A' && coords[0] <= 'H' && coords[1] >= '1' && coords[1] <= '8';
		}
		protected static int GetDX (string coordsA, string coordsB)
		{
			return Math.Abs( coordsA[0] - coordsB[0] );
		}
		protected static int GetDY (string coordsA, string coordsB)
		{
			return Math.Abs( coordsA[1] - coordsB[1] );
		}
	}

	class PawnFigure : ChessFigure
	{
		public PawnFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (!IsValidCoordinates( nextCoord ))
				return false;

			if (nextCoord[0] != currentCoord[0] || nextCoord[1] <= currentCoord[1] || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' || nextCoord[1] != '4')))
				return false;
			else
				return true;
		}
	}

	class RookFigure : ChessFigure
	{
		public RookFigure (string currentCoord) : base( currentCoord ) { 
		}

		internal override bool Move (string nextCoord)
		{
			if (!IsValidCoordinates( nextCoord ))
				return false;

			if ((nextCoord[0] != currentCoord[0]) && (nextCoord[1] != currentCoord[1]) || ((nextCoord[0] == currentCoord[0]) && (nextCoord[1] == currentCoord[1])))
				return false;
			else
				return true;
		}
	}

	class KnightFigure : ChessFigure
	{
		public KnightFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (!IsValidCoordinates( nextCoord ))
				return false;

			int dx = GetDX( nextCoord, currentCoord );
			int dy = GetDY( nextCoord, currentCoord );
			return dx == 1 && dy == 2 || dx == 2 && dy == 1;
		}
	}
	class BishopFigure : ChessFigure
	{
		public BishopFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (!IsValidCoordinates( nextCoord ))
				return false;

			int dx = GetDX( nextCoord, currentCoord );
			int dy = GetDY( nextCoord, currentCoord );
			return dx == dy;
		}
	}
	class QueenFigure : ChessFigure
	{
		public QueenFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (!IsValidCoordinates( nextCoord ))
				return false;

			int dx = GetDX( nextCoord, currentCoord );
			int dy = GetDY( nextCoord, currentCoord );
			if (!(dx == dy || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1]))
					return false;
				else
					return true;
		}
	}
	class KingFigure : ChessFigure
	{
		public KingFigure (string currentCoord) : base( currentCoord )
		{
		}
		internal override bool Move (string nextCoord)
		{
			if (!IsValidCoordinates( nextCoord ))
				return false;

			int dx = GetDX( nextCoord, currentCoord );
			int dy = GetDY( nextCoord, currentCoord );
			return (dx <= 1 && dy <= 1);
		}
	}
}
