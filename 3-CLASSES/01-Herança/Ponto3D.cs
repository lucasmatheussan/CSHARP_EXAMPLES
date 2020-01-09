namespace CLASSES.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) :base(x,y){
            CalcularDistancia();
        }
        public static void Calcular(){

        }
        public override void CalcularDistancia3(){
            base.CalcularDistancia3();
        }

    }
}