using System;

namespace Calculadora
{
    internal class BigInteger
    {
        public static object Zero { get; internal set; }

        internal static BigInteger Add(BigInteger num1, BigInteger num2)
        {
            throw new NotImplementedException();
        }

        internal static BigInteger Divide(BigInteger num1, BigInteger num2)
        {
            throw new NotImplementedException();
        }

        internal static BigInteger Multiply(BigInteger num1, BigInteger num2)
        {
            throw new NotImplementedException();
        }

        internal static BigInteger Parse(string text)
        {
            throw new NotImplementedException();
        }

        internal static BigInteger Subtract(BigInteger num1, BigInteger num2)
        {
            throw new NotImplementedException();
        }

        internal int CompareTo(object zero)
        {
            throw new NotImplementedException();
        }

        public static implicit operator BigInteger(int v)
        {
            throw new NotImplementedException();
        }
    }
}