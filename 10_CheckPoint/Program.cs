using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*
 * Name: _10_CheckPoint
 * DESC: 배열을 활용하기
 */

namespace _10_CheckPoint
{
    class Program
    {
        const int mapX = 7;
        const int mapY = 22;
        const int delayTime = 300;

        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < mapX; i++)
            {
                for (int j = 0; j < mapY; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                    if (j == mapY - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }

        static void ClearView()
        {
            Thread.Sleep(delayTime);
            Console.Clear();
        }

        static void UpdateGo(int[] _arrIndex_X, int[,] _map)
        {
            for (int i = 0; i < _arrIndex_X.Length; i++)
            {
                int indexMaxX = i + 1;
                int indexY = _arrIndex_X[i];

                int temp = _map[indexMaxX, indexY]; //temp = 3;
                _map[indexMaxX, indexY + 1] = temp;
                _map[indexMaxX, indexY] = 0;               
                
                _arrIndex_X[i]++;
                
            }
        }

        static bool UpdateRandomGo(int[] _arrIndex_X, int[,] _map, Random _rnd)
        {
            bool isFinish = false;

            for (int i = 0; i < _arrIndex_X.Length; i++)
            {
                if (_arrIndex_X[i] >= 19)
                {
                    isFinish = true;
                    break;
                }
            }

            int rndIndex = _rnd.Next(0, 5); // 0 ~ 4

            int indexY = _arrIndex_X[rndIndex];

            int temp = _map[rndIndex + 1, indexY]; // rndIndex 0일 경우 map[1, ?], rndIndex 1일 경우 map[2, ?]
            _map[rndIndex + 1, indexY + 1] = temp;
            _map[rndIndex + 1, indexY] = 0;

            _arrIndex_X[rndIndex]++;

            return isFinish;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            //               0    1    2    3    4    5    6    7
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[mapX, mapY]
            {
                //0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, //0
                { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //1
                { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //2
                { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //3
                { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //4
                { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0}, //5
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}  //6
            };

            int[] arrIndex_X = {0, 0, 0, 0, 0 };
            bool isFinish = false;

            while(true)
            {              
                UpdateGo(arrIndex_X, map);
                isFinish = UpdateRandomGo(arrIndex_X, map, rnd);
                UpdateView(tile, map);

                if (isFinish)
                {
                    Console.WriteLine();
                    for (int i = 0; i < arrIndex_X.Length; i++)
                    {
                        if (arrIndex_X[i] >= 19)
                        {
                            Console.WriteLine($"달리기 결과 1등: " + (i + 1));
                            break;
                        }
                    }

                    Console.WriteLine($"\n다시 시작하려면 0을 입력하세요. ");
                    string inputStr = Console.ReadLine();

                    if (inputStr == "0")
                    {
                        map[1, arrIndex_X[0]] = 0;
                        map[2, arrIndex_X[1]] = 0;
                        map[3, arrIndex_X[2]] = 0;
                        map[4, arrIndex_X[3]] = 0;
                        map[5, arrIndex_X[4]] = 0;

                        arrIndex_X[0] = 0;
                        arrIndex_X[1] = 0;
                        arrIndex_X[2] = 0;
                        arrIndex_X[3] = 0;
                        arrIndex_X[4] = 0;

                        map[1, 20] = 2;
                        map[2, 20] = 2;
                        map[3, 20] = 2;
                        map[4, 20] = 2;
                        map[5, 20] = 2;

                        map[1, 0] = 3;
                        map[2, 0] = 4;
                        map[3, 0] = 5;
                        map[4, 0] = 6;
                        map[5, 0] = 7;
                    }
                    else
                    {
                        Console.Write("\n나가기");
                        break;
                    }
                }

                ClearView();
            }               
        }
    }
}
