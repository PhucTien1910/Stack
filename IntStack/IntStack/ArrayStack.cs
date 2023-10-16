using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    internal class ArrayStack
    {
        //Atribute
        private int[] stkArray;
        private int stkMax;
        private int stkTop;

        //Get/Set
        public int[] StkArray
        {
            get { return stkArray; }
            set { stkArray = value; }
        }
        public int StkMax
        {
            get { return stkMax; }
            set { stkMax = value; }
        }
        public int StkTop
        {
            get { return stkTop; }
            set { stkTop = value; }
        }

        //Constructor
        public ArrayStack(int max = 0)
        {
            stkMax = max;
            stkArray = new int[max];
            stkTop = -1;
        }       
        public bool IsEmpty => stkTop == -1;
        public bool IsFull => stkTop == stkMax - 1;
        public bool Push(int x)
        {
            
        }
        public bool Pop(out int outItem)
        {
            throw new NotImplementedException();
        }
        public bool GetTop(out int outItem)
        {
            throw new NotImplementedException();
        }
    }
}
