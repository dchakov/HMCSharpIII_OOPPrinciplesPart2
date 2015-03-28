using System;

namespace Problem03RangeExceptions
{
    public class InvalidRangeExeption<T> : ApplicationException
    {
        private T start;
        private T end;

        public T Start
        {
            get { return this.start; }
            set { this.start = value; }
        }
        public T End
        {
            get { return this.end; }
            set { this.end = value; }
        }
        public InvalidRangeExeption(string message, T start, T end, Exception inner)
            : base(message, inner)
        {
            this.Start = start;
            this.End = end;
        }
        public InvalidRangeExeption(string message, T start, T end)
            : base(message)
        {
        }
    }
}
