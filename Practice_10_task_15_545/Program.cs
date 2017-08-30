using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10_task_15_545
{
    class Program
    {
        static Point MadeList(int N)
        {//функция создания исходного списка-круга
            Point list = new Point();
            Point beg = new Point();
            beg = list;
            for (int i = 1; i <= N; i++)
            {
                beg.Info = i;
                if (i == N) beg.Next = list;
                else
                {
                    beg.Next = new Point();
                    beg = beg.Next;
                }
            }
            return list;
        }

        static int FindLast(int N, int M, Point list)
        {//функция поиска последнего человека из круга, оставшегося после считалки
            Point beg = new Point();
            beg = list;
            do
            {
                for (int i=1; i<=M-1; i++)//считаем до тех пор, пока не дойдем до M-1-ого элемента
                {
                    if (i == M-1)//если следующий элемент M-ый
                    {
                        Console.WriteLine("Участник под номером " + (i+1) + "выбыл");
                        beg.Next = beg.Next.Next;//Удаляем следующий элемент
                    }
                    beg = beg.Next;//передвигаемся на следующий элемент
                }
            } while (beg.Info != beg.Next.Info);//до тех пор, пока не останется один элемент (следующий за ним не будет равен ему же)
            return beg.Info;
        }
     
        static void Main(string[] args)
        {

        }
    }
}
