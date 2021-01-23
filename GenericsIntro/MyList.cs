using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //Cunstructor
        public MyList()
        {
            items = new T[0]; // 0 elemanli bir dizim var 
        }
        public void Add(T item) // T = gelecek veri tipi
        {
            T[] tempArray = items; //gecicidizi de referansı tutuyorum elemanlarım kaybolmayacak.
            items = new T[items.Length + 1]; // newlediğim an referans numarası başka olacağından elemanlarım uçmasın diye geçiciye attim
            for(int i =0;i<tempArray.Length;i++)
            {
                items[i] = tempArray[i]; // geiciye verdigim degerleri aliyorum
            }

            items[items.Length - 1] = item; 
        }
    }
}
