using System;
using ESTRUTURADOPROGRAMA;
namespace ESTRUTURADOPROGRAMA{
    public class Program{
        static void Main(){
            var pilha = new Pilha();
            pilha.push(43);
            pilha.push(13);
            pilha.push(10);
            pilha.push(12);
            pilha.push(8);
            for(int i =0;i<5;i++){
                Console.WriteLine(pilha.pop());
            }
        }

    }

}