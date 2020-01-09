namespace CLASSES.Metodos
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y){
            int tmp = x;
            x = y;
            y = tmp;
        }//ref -> ponteiro 
        public static void Inverter(){
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");
        }
    }
}