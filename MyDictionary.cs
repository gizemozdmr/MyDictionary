using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictionary<KeyType, ValueType>
    {
        KeyType[] keys;
        ValueType[] values;
        KeyType[] tempKeys;
        ValueType[] tempValues;

        public MyDictionary()
        {
            keys = new KeyType[0];
            values = new ValueType[0];
        }
        
        public void Add (KeyType key, ValueType value)
        {
            tempKeys = keys;
            keys = new KeyType[keys.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++) 
            {
                keys[i] = tempKeys[i];
            }
            keys[keys.Length - 1] = key;

            tempValues = values;
            values = new ValueType[values.Length + 1];
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            values[values.Length - 1] = value;

        }
        public int valueCount
        {
            get { return values.Length; }

        }
        public int keyCount
        {
            get { return keys.Length; }
        }

        public KeyType[] keyArray
        {
            get { return keys; }
        }
        public ValueType[] valueArray
        {
            get { return values; }
        }

        public void Al(KeyType anahtar)
        {
            int sira = Array.IndexOf(keys, anahtar);
            Console.WriteLine(values[sira]);
        }


    }
}