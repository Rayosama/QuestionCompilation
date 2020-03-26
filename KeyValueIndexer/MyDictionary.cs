using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueIndexer
{
   public class MyDictionary
    {
        public int Capacity { get; set; }

        public KeyValue[] Values { get; set; }

        public MyDictionary()
        {
            Capacity = 10;
            Values = new KeyValue[Capacity];
        }


        public object this[string key]
        {
            get 
            {
                for(int i = 0; i <KeyValue.L)
            }
            set
            {

            }
        }


    }
}
