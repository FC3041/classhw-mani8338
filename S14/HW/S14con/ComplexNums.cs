using System;
using System.Numerics;

public class ComplexNumber<T> 
    where T : INumber<T>
{
    public T Real { get; set; }
    public T Imaginary { get; set; }

    public ComplexNumber(T r,T im)
    {
        Real = r;
        Imaginary = im;
    }

    public ComplexNumber<T> Add(ComplexNumber<T> o)
    {
        return new ComplexNumber<T>(Real+o.Real,Imaginary+o.Imaginary);       
    }

    public double Magnitude => Math.Sqrt(Convert.ToDouble(Real*Real)+Convert.ToDouble(Imaginary*Imaginary));

    public override string ToString()
    {
        return $"{Real}+{Imaginary}i";
    }

    public override bool Equals(object obj)
    {
        if (obj is ComplexNumber<T> o)
        {
            return Real.Equals(o.Real) && Imaginary.Equals(o.Imaginary);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Real.GetHashCode() ^ Imaginary.GetHashCode();
    }
}


