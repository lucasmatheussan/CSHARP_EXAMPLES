namespace ESTRUTURADOPROGRAMA
{
    public class Pilha
    {
        public No primeiro;
        public No ultimo;
        public void push(int dado){
            if(this.primeiro == null){
                this.primeiro = new No(dado,null);
                this.ultimo = this.primeiro;
            }else{
                No NovoNo = new No(dado,null);
                this.ultimo.proximo = NovoNo;
                this.ultimo = NovoNo;
            }
        }

        public object pop(){
            if(primeiro == null){
                return "A pilha está vazia";
            }
            No NovoPrimeiro = this.primeiro;
            this.primeiro = this.primeiro.proximo;
            return NovoPrimeiro.dado;
        }
    }
    public class No{
        public int dado;
        public No proximo;

        public No(int dado, No proximo){
            this.dado = dado;
            this.proximo = proximo;
        }
    }
}