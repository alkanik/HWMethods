using HWMethods;

int [,] a = new int[,] {
						{5,10,38,-10,100 },
						{7,65,14,9,19 },
						{3,47,15,65,1 },
						{3,654,15,6,1 },
						{32,7,15,5,13 }
					};
Console.WriteLine(TwoDArraysController.GetCountElementsLargerThanNeighbors(a));