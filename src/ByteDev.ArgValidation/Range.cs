using System;
using System.Collections.Generic;

namespace ByteDev.ArgValidation
{
    internal class Range<T>
    {
        private readonly Comparer<T> _comparer;

        public T From { get; }

        public T To { get; }

        public Range(T from, T to)
        {
            _comparer = Comparer<T>.Default;

            if (_comparer.Compare(from, to) > 0)
                throw new ArgumentException("Range from value should be less than or equal to the range to value.");

            From = from;
            To = to;
        }

        public bool IsInRange(T value)
        {
            return _comparer.Compare(value, From) >= 0 &&
                   _comparer.Compare(value, To) <= 0;
        }
    }
}