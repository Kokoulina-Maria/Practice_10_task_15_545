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

        static void Main(string[] args)
        {

        }
    }
}
