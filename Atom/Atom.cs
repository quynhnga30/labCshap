using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab341
{
    class Atom
    {
        public int atomnb = 0;
        public string atomsb;
        public string atomfn;
        public float atomw = 0;

        public Atom(int atomnb, string atomsb, string atomfn, float atomw)
        {
            this.atomfn = atomfn;
            this.atomsb = atomsb;
            this.atomnb = atomnb;
            this.atomw = atomw;

        }
        public Atom() { }
        public void display()
        {
            Console.WriteLine("{0}\t\t{1}\t{2}\t{3}", atomfn, atomsb, atomnb, atomw);
        }

    }
}
