using System;

namespace _2_INSTRUCOES
{
    class Program
    {
        static void Declaracoes(){
            int a = 10;
            int b  = 2, c =3;
            const int d  = 4;
            a = 10;
            Console.WriteLine(a+b+c+d);
        }
        static void intruscoesIF(string[] args){
            if(args.Length == 0){
                Console.WriteLine("Nenhum argumento");
            }
            else if(args.Length == 1){
                Console.WriteLine("Um argumento.");
            }
            else{
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void IntrucoesSwitch(string[] args){
            int numeroDeArgumentos = args.Length;

            switch(numeroDeArgumentos){
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }
      
        static void InstrucoesWhile(string [] args){
            int cont  = 0;
            while(cont < args.Length){
                Console.WriteLine($"While rodou {cont} vezes");
                cont++;
            }
        }
      
        static void IntrucoesDoWhile(string [] args){
            string texto;
            do{
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            }while(!string.IsNullOrEmpty(texto));
        }
       
        static void IntrucoesFor(string [] args){
            for(int i =0;i< args.Length;i++){
                Console.WriteLine(i); 
            }
        }

        static void IntrucoesForeach(string [] args){
            foreach(string s in args){
                Console.WriteLine(s);
            }
        }
       
       static void IntrucoesBreak(){
           while(true){
               string texto = Console.ReadLine();
               if(!string.IsNullOrEmpty(texto)){
                   break;
               }
           }
       }
        
       static void InstrucoesContinue(string [] args){
           for(int i = 0;i<args.Length;i++){
               if(args[i].StartsWith("a")){
                   continue;
               }
               Console.WriteLine(args[i]);
           }

       }
        
       static void IntrucoesTryCatchFinallyThrow(string [] args){
           double Dividir(double a, double b){
               if(b == 0){
                   throw new DivideByZeroException();
               }
               return a/b;
           }
           int a  = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           try{
               if(args.Length < 2){
                   throw new InvalidOperationException("Infome dois argumentos");
               }else{
                   double x = a;
                   double y = b;
                   Console.WriteLine(Dividir(x,y));
               }
           }catch(InvalidOperationException e){
               Console.WriteLine(e.Message);
           }catch(Exception e){
               Console.WriteLine($"Erro genérico: {e.Message}");
           } finally{
               Console.WriteLine("Até Breve!!");
           }
       }
       
       static void IntrucaoUsing(string [] args){
           using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt")){
               w.Write("Linha 1\n");
               w.Write("Linha 2\n");
               w.Write("Linha 3\n");
           }
       }
       static void Main(string [] args){
            string [] palavra = "p ap l as v r pa".Split(" "); 
            // Declaracoes();
            // intruscoesIF(palavra);
            // IntrucoesSwitch(palavra);
            // InstrucoesWhile(palavra);
            // IntrucoesDoWhile(palavra);
            // IntrucoesFor(palavra);
            // IntrucoesForeach(palavra);
            // IntrucoesBreak();
            //InstrucoesContinue(palavra);
            // IntrucoesSwitch(palavra);
            //IntrucoesTryCatchFinallyThrow(palavra);
            IntrucaoUsing(palavra);

        }
    }
}
