using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_practice
{
    class Node
    {
        public int _value {get; set;}
        public Node next { get; set; }
        public Node Previous { get; set; }
        public Node(int value)
        {
            this._value = value;
        }
    }
}
