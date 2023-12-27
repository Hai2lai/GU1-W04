﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mineText
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };
            int chieu_ngang = map.GetLength(0);
            int chieu_doc = map.GetLength(1);

            string[,] mapReport = new string[chieu_ngang, chieu_doc];
            for (int y = 0; y < chieu_ngang; y++)
            {
                for (int x = 0; x < chieu_doc; x++)
                {
                    if (map[y, x].Equals("*"))
                    {
                        mapReport[y, x] = "*";
                    }
//........................................................................
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = {
                        {y - 1, x - 1}, {y - 1, x}, {y - 1, x + 1},
                        {y, x - 1}, {y, x + 1},
                        {y + 1, x - 1}, {y + 1, x}, {y + 1, x + 1},};

                        int minesAround = 0;
                        int length = NEIGHBOURS_ORDINATE.GetLength(0);
                        for (int i = 0; i < length; i++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0
                                    || xOrdinateOfNeighbour == chieu_doc
                                    || yOrdinateOfNeighbour < 0
                                    || yOrdinateOfNeighbour == chieu_ngang;
                            if (isOutOfMapNeighbour)
                            {
                                continue;
                            }

                            bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour)
                            {
                                minesAround++;
                            }
                        }
//...........................................................................
                        mapReport[y, x] = minesAround.ToString();
                    }
                }
            }
            for (int y = 0; y < chieu_ngang; y++)
            {
                Console.WriteLine();
                for (int x = 0; x < chieu_doc; x++)
                {
                    Console.Write(mapReport[y, x]+" ");
                }
            }
        }
    }
}