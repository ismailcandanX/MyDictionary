using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, Y>
    {
        T[] forKey;
        Y[] forValue;

        public MyDictionary()
        {
            forKey = new T[0];
            forValue= new Y[0];
        }
        public void Add(T key,Y value)
        {
            T[] tempForKey = forKey;
            Y[] tempForValue = forValue;

            forKey = new T[forKey.Length + 1];
            forValue = new Y[forValue.Length + 1];

            for (int i = 0; i < tempForKey.Length; i++)
            {
                forKey[i] = tempForKey[i];
            }
            for (int i = 0; i < tempForValue.Length; i++)
            {
                forValue[i] = tempForValue[i];
            }

            forKey[forKey.Length - 1] = key;
            forValue[forValue.Length - 1] = value;

        }
    }
}
