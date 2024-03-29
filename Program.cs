﻿using System;

namespace n_queens_dotnet
{
  class Program
  {
    const int queenCount = 13;
    static int[] queenList;

    static void Main(string[] args)
    {
      testEightQueens();
    }

    static void testEightQueens()
    {
      queenList = new int[queenCount];
      putQueen(0);
    }

    static bool checkConflict(int nextY)
    {
      for (int positionY = 0; positionY < nextY; positionY++)
      {
        if (Math.Abs(queenList[positionY] - queenList[nextY]) == Math.Abs(positionY - nextY) || queenList[positionY] == queenList[nextY])
        {
          return true;
        }
      }
      return false;
    }

    static int count = 0;
    static void putQueen(int nextY)
    {
      for (queenList[nextY] = 0; queenList[nextY] < queenCount; queenList[nextY]++)
      {
        if (checkConflict(nextY) == false)
        {
          nextY++;
          if (nextY < queenCount)
          {
            putQueen(nextY);
          }
          else
          {
            count++;
            Console.WriteLine(count.ToString() + ": " + string.Join(", ", queenList));
          }
          nextY--;
        }
      }
    }
  }
}
