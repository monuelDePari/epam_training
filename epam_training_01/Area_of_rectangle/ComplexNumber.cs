using System;
using System.Collections.Generic;
using System.Text;
namespace Area_of_rectangle
{
    class ComplexNumber
    {
        #region fields 
        private double real, imaginary;
        #endregion
        #region constor
        public ComplexNumber() { } // default ctor
        #endregion
        #region props
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public double Real
        {
            get { return real; }
            set { real = value; }
        }
        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }
        #endregion
        #region overloading
        public static ComplexNumber operator *(ComplexNumber complex1, ComplexNumber complex2)
        {
            ComplexNumber complex = new ComplexNumber();
            if (complex1.imaginary != complex2.imaginary && complex1.Real != complex2.Real)
            {
                complex.Real = complex1.Real * complex2.Real;
                complex.Imaginary = complex1.Real * complex2.Imaginary;
                complex.Imaginary += complex1.Imaginary * complex2.Real;
                complex.Real += (-1) * (complex1.Imaginary * complex2.Imaginary);
            }else if(complex1.Real == complex2.Real && complex1.imaginary == (-1) * complex2.imaginary)
            {
                complex.Real = (complex1.Real * complex2.Real) + (-1) * (complex1.Imaginary * complex2.Imaginary);
                complex.imaginary = 0;
            }
            return complex;
        }
        public static ComplexNumber operator /(ComplexNumber complex1, ComplexNumber complex2)
        {
            ComplexNumber complex = new ComplexNumber();
            ComplexNumber complex_div = new ComplexNumber();
            complex_div.Real = complex2.Real;
            complex_div.Imaginary = (-1) * complex2.Imaginary;
            complex = complex1 * complex_div;
            complex_div = complex_div * complex2;
            complex.Real = complex.Real / complex_div.Real;
            return complex;
        }
        #endregion
        #region methods
        public void output(ComplexNumber complex)
        {
            if(complex.Imaginary < 0)
                Console.WriteLine(complex.Real + "" + complex.Imaginary + "*i");
            else
                Console.WriteLine(complex.Real + "+" + complex.Imaginary + "*i");
        }
        #endregion
    }
}
