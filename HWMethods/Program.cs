﻿using HWMethods;

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

int[,] a = TwoDArraysController.GenerateRandom(x,y);

TwoDArraysController.Print(a);

Console.WriteLine(TwoDArraysController.GetCountElementsLargerThanNeighbors(a));
