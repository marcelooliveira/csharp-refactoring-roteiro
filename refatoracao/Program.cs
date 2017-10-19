using refatoracao.R06.SplitTemporaryVariable;
using refatoracao.R08.ReplaceMethodWithMethodObject;
using System;

namespace refatoracao
{
    class Program
    {
        static void Main(string[] args)
        {
            var retangulo = new Retangulo(3, 4);
            Console.WriteLine();

            new R08.ReplaceMethodWithMethodObject.antes.Produto(100, 10, 5);
            Console.WriteLine();
            new R08.ReplaceMethodWithMethodObject.depois.Produto(100, 10, 5);
            Console.WriteLine();


        }
    }
}
