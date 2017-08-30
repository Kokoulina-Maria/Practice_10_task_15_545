using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10_task_15_545
{
    class Point
    {//класс для элемента списка
        int info;//информационное поле
        Point next;//адресное поле

        //свойства

        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Point Next
        {
            get { return next; }
            set { next = value; }
        }

        //конструкторы

        public Point()//конструктор без параметров
        {
            info = default(int);
            next = null;
        }

        public override string ToString()
        {
            return info + " ";
        }
    }
}
