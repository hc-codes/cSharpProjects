using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    public class MyArray
    {
        private object[] objects = new object[3];
        public void Add(object item)
        {
            if (objects.Length <= c)
            {
                object[] temp = new object[objects.Length * 2];
                for (int i = 0; i < 8; i++)
                {

                    temp[i] = objects[i];
                }
            }
            
        }
        public void Show()
        {
            foreach (var obj in objects)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
