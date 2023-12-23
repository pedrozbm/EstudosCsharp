namespace Classes
{
    internal class Triangulo
    {

        public Double A;
        public Double B;
        public Double C;

        public double Area()
        {//Esse é um método, uma função dentro de uma classe

            double p = (A + B + C) / 2.00;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
