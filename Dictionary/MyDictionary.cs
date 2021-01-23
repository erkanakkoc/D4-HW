using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TK,TV> // TK->tKeys , TV->tValues
    {
        TK[] _tKeys;
        TV[] _tValues;
        //constructor
        public MyDictionary()
        {
            _tKeys = new TK[0];
            _tValues = new TV[0];

        }
        public void Add(TK tKey, TV tValue)
        {
            TK[] _tempK = _tKeys;
            TV[] _tempV = _tValues;
            _tKeys = new TK[_tKeys.Length + 1];
            _tValues = new TV[_tValues.Length + 1];
            for (int i = 0; i < _tempK.Length; i++)
            {
                _tKeys[i] = _tempK[i];
                _tValues[i] = _tempV[i];
            }
            _tKeys[_tKeys.Length - 1] = tKey;
            _tValues[_tValues.Length - 1] = tValue;
        }

        public int Count 
        {
            get { return _tKeys.Length; }
        }

        public TK[] Keys
        {
            get { return _tKeys; }
        }

        public TV[] Values  
        {
            get { return _tValues; }
        }

        public void Show()
        {
            for (int i = 0; i < _tKeys.Length; i++)
            {
                Console.WriteLine("Student ID: " +_tKeys[i]+" - Student Name: "+_tValues[i]);
            }
            Console.WriteLine("---------------------------------------------------");
        }
    }   



}
