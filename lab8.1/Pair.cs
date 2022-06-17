﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8._1
{
    class Pair<T>
    {
        private T first;
        private T second;

        public Pair(T first, T second)
        {
            this.first = first;
            this.second = second;
        }

        public T First
        {
            get { return first; }
        }

        public T Second
        {
            get { return second; }
        }


    }
}
