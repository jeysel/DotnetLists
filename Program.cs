using System;

namespace DotnetLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /*
            //percorrendo o array
            for (var index = 0; index < meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }
            */

            /*
            // foreach
            var meuArray = new int[5] { 1, 2, 3, 4, 5 };
            meuArray[0] = 12;

            //Console.WriteLine(meuArray[0]);

            Console.WriteLine(meuArray.Length);
            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }
            */

            // tratamento de erro

            var arr = new int[3];

            try
            {
                for (var index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr[index]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Indice não encontrado.");

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }

            finally
            {
                Console.WriteLine("fim");
            }


        }

        static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }

            public DateTime QuandoAconteceu { get; set; }
        }


    }

}
