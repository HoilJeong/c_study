using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Check
{
    class Program
    {
        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요. ");
            ID[index] = int.Parse(Console.ReadLine());          
        }

        static void InputKor(int[] kor, int index)
        {
            Console.Write("국어 점수를 입력하세요. ");
            kor[index] = int.Parse(Console.ReadLine());
        }

        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요. ");
            math[index] = int.Parse(Console.ReadLine());
        }

        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요. ");
            eng[index] = int.Parse(Console.ReadLine());         
        }

        static void PrintID(int max, int[] ID)
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"학생 ID: " + ID[i]);
            }
        }

        static int CheckID(int id, int max, int[] ID)
        {
            for (int i = 0; i < max; i++)
            {
                if (ID[i] == id)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            const int Max = 3;
            int[] ID = new int[Max];
            int[] kor = new int[Max];
            int[] math = new int[Max];
            int[] eng = new int[Max];
          
            int inputsel = 0;
            int serchID = -1;

            for (int i = 0; i < 3; i++)
            {
                InputID(ID, i);
                InputKor(kor, i);
                InputMath(math, i);
                InputEng(eng, i);
            }         

            while (true)
            {
                PrintID(Max, ID);
                Console.WriteLine("학생 아이디를 입력하세요. (0)나가기");
                inputsel = int.Parse(Console.ReadLine());

                if (inputsel == 0)
                {
                    break;
                }

                serchID = CheckID(inputsel, Max, ID);

                if (serchID >= 0)
                {
                    Console.WriteLine($"국어 점수: " + kor[serchID]);
                    Console.WriteLine($"수학 점수: " + math[serchID]);
                    Console.WriteLine($"영어 점수: " + eng[serchID]);
                    Console.WriteLine($"총점: " + (kor[serchID] + math[serchID] + eng[serchID]));
                    Console.WriteLine($"평균: " + ((kor[serchID] + math[serchID] + eng[serchID]) / 3));
                }
                else
                {
                    Console.WriteLine("학생 아이디가 없어요.");
                }
            }
        }
    }
}
