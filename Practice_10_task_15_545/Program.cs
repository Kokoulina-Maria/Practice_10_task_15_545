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
                    if (i == M-1) //если следующий элемент M-ый
                    {
                        Console.WriteLine("Участник под номером " + beg.Next.Info + " выбыл");
                        beg.Next = beg.Next.Next;//Удаляем следующий элемент
                    }
                    beg = beg.Next;//передвигаемся на следующий элемент
                }
            } while (beg.Info != beg.Next.Info);//до тех пор, пока не останется один элемент (следующий за ним не будет равен ему же)
            return beg.Info;
        }

        static int Readint(string msg, string msg1)
        {// Ввод натурального числа, не равного единице, с проверкой
            int number; bool ok;// переменная для проверки
            do
            {
                Console.Write(msg);
                ok = int.TryParse(Console.ReadLine(), out number);
                if (!ok) Console.WriteLine("Неверный ввод!");
                if (number <= 1)
                {
                    ok = false;
                    Console.WriteLine(msg1);
                }
            } while (!ok);// конец проверки
            return (number);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Считалка");
            do
            {
                int n;//Количество участников
                int m;//Конечное число считалки
                n = Readint("Введите количество участников: ", "В круге должно быть больше одного человека!");               
                m = Readint("Введите m, количество слов в считалке: ", "В считалке должно быть больше одного слова!");
                Point list = new Point();//список
                list = MadeList(n);//создаем начальный список
                int last = FindLast(n, m, list);//ищем последнего человека
                Console.WriteLine("Номер оставшегося человека: " + last);
                Console.ReadLine();
            } while (true);
        }
    }
}
