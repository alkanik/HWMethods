using System;
namespace HWMethods.Test
{
	public enum TwoDArraysMockType
    {
		one,
		oneFlip,
		two,
		three,
		threeFlip,
		notSquare,
		empty
    }


	public static class TwoDArraysMock
	{
		public static int[,] GetMock(TwoDArraysMockType type)
		{
			switch (type)
            {
				case TwoDArraysMockType.one:
					return new int[,] {
						{1,2,3 },
						{2,3,4 },
						{3,4,5 }
					};
				case TwoDArraysMockType.oneFlip:
					return new int[,] {
						{1,2,3 },
						{2,3,4 },
						{3,4,5 }
					};
				case TwoDArraysMockType.two:
					return new int[,] {
						{0,1,2,3 },
						{1,2,3,4 },
						{2,3,4,5 },
						{3,4,5,6 }
					};
				case TwoDArraysMockType.three:
					return new int[,] {
						{5,10,38,-10,100 },
						{7,65,14,9,19 },
						{3,47,15,65,1 },
						{3,654,15,6,1 },
						{32,7,15,5,13 }
					};
				case TwoDArraysMockType.threeFlip:
					return new int[,] {
						{5,7,3,3,32 },
						{10,65,47,654,7 },
						{38,14,15,15,15 },
						{-10,9,65,6,5 },
						{100,19,1,1,13 }
					};
				case TwoDArraysMockType.notSquare:
					return new int[,] {
						{5,7,3,3,32 },
						{10,65,47,654,7 },
						{38,14,15,15,15 },
					};
				case TwoDArraysMockType.empty:
					return new int[,] {};
				default:
					throw new Exception();
			}
		}
	}
}

