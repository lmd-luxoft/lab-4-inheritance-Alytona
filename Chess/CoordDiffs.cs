using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	public struct CoordDiffs
	{
		public readonly int Dx;
		public readonly int Dy;

		public CoordDiffs (string coordsA, string coordsB)
		{
			Dx = Math.Abs( coordsA[0] - coordsB[0] );
			Dy = Math.Abs( coordsA[1] - coordsB[1] );
		}
		public bool IsValidDiagonalMove ()
		{
			return Dx == Dy;
		}
		public bool IsValidDirectMove ()
		{
			return Dx == 0 || Dy == 0;
		}
	}
}
