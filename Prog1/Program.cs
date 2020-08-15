using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public class GenericList<T> where T : struct
        {
            List<T> _list = new List<T>();
            public void add(T item)
            {
                _list.Add(item);
            }
            public T get(int index)
            {
                if (index < _list.Count)
                {
                    return _list[index];
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException ;
                }

            }

            public Collection<T> Order_Desc()
            {

                return _list.
            }
        }
    }
}
