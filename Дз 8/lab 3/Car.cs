using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace lab_3
{
    [Serializable]
    class Car
    {
        public Int32 carId;
        public decimal price;
        public Int32 quantity;
        public decimal total;

        public Car() { }
    }
}
