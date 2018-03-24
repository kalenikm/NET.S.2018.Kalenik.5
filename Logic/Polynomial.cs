using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Logic
{
    public struct Polynomial
    {
        private readonly double[] _coefficients;

        /// <summary>
        /// Takes cofficients from double array.
        /// </summary>
        /// <param name="koefs">Coefficients of a polynomial.</param>
        public Polynomial(params double[] koefs)
        {
            if(koefs == null)
                throw new ArgumentNullException($"Array {nameof(koefs)} is null.");
            _coefficients = new double[koefs.Length];

            koefs.CopyTo(_coefficients, 0);
        }

        #region Overrided Object methods

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            if (!_coefficients[0].Equals(0.0))
                str.Append(_coefficients[0]);
            for (int i = 1; i < _coefficients.Length; i++)
            {
                if (!_coefficients[i].Equals(0.0))
                    str.Append(" + " + _coefficients[i] + "x^" + i);
            }
            return str.ToString();
        }

        public override int GetHashCode()
        {
            int x = 1;
            int d = 0;
            foreach (double coef in _coefficients)
            {
                int point = coef.ToString(CultureInfo.InvariantCulture).IndexOf(".", StringComparison.Ordinal);
                int pow = coef.ToString(CultureInfo.InvariantCulture).Length - (point == -1 ? 0 : point);
                d += (int)Math.Pow((int)(coef * Math.Pow(10, pow)), x);
                x++;
            }
            return d;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException();

            if (!(obj is Polynomial))
                return false;

            return _coefficients.SequenceEqual(((Polynomial) obj)._coefficients);
        }

        #endregion

        #region Overrided operators

        public static bool operator ==(Polynomial p1, Polynomial p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Polynomial p1, Polynomial p2)
        {
            return !p1.Equals(p2);
        }

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            var max = p1._coefficients.Length > p2._coefficients.Length ? p1._coefficients : p2._coefficients;
            var min = p1._coefficients == max ? p2._coefficients : p1._coefficients;

            double[] array = new double[max.Length];

            max.CopyTo(array, 0);
            for (int i = 0; i < min.Length; i++)
            {
                array[i] += min[i];
            }
            return new Polynomial(array);
        }

        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            var max = p1._coefficients.Length > p2._coefficients.Length ? p1._coefficients : p2._coefficients;

            double[] array = new double[max.Length];

            max.CopyTo(array, 0);

            for (int i = 0; i < p2._coefficients.Length; i++)
            {
                array[i] -= p2._coefficients[i];
            }
            return new Polynomial(array);
        }

        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            var array = new double[p1._coefficients.Length + p2._coefficients.Length - 1];

            for (int i = 0; i < p1._coefficients.Length; i++)
            {
                for (int j = 0; j < p2._coefficients.Length; j++)
                {
                    array[i + j] += p1._coefficients[i] * p2._coefficients[j];
                }
            }
            return new Polynomial(array);
        }

        #endregion
    }
}