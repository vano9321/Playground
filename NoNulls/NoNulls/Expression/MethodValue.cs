﻿using System;

namespace NoNulls
{
    public class MethodValue<T> 
    {
        private readonly bool _validChain;
        private T _value;

        public T Value
        {
            get
            {
                if (ValidChain())
                {
                    return _value;   
                }
                throw new NoValueException("The property does not exist. Failure was at {0}", Failure);
            }
            private set
            {
                _value = value;
            }
        }

        public String Failure { get; set; }

        public MethodValue(T value, String failure, bool validChain)
        {
            _validChain = validChain;
            Value = value;
            Failure = failure;
        }


        public bool ValidChain()
        {
            return _validChain;
        }
    }
}