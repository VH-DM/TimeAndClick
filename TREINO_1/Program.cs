using System;
using System.Threading;

class Program{

    static void Main(){

        do{
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Thread.Sleep(1000);
            
        }while(Console.KeyAvailable == false);

            Console.WriteLine("adios *o tempo para*");

    }
}