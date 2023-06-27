﻿internal class Program
{
    private static void Main(string[] args)
    {
        LinqQueries queries = new LinqQueries();
         ImprimirValores(queries.AllCollection());
       
    }

    private static void ImprimirValores(IEnumerable<Book> books)
    {
        int registros = 0;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("{0,-70} {1,7} {2,20}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach (Book book in books)
        {
            registros += 1;
            Console.WriteLine("{0,-70} {1,7} {2,20}", book.Title, book.PageCount, book.PublishedDate.ToShortDateString());
            if (registros % 10 == 0)
            {
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("{0,-70} {1,7} {2,20}\n", "Titulo", "N. Paginas", "Fecha publicacion");
            }
        }
    }
}