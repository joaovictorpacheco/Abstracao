using System;

namespace Abstração.classes
{
    public abstract class Pagamento
    {
        //Atributos
        private DateTime data;
        protected float valor;

        //Metodos 
        public string Cancelar(){
            return "";
        }
        public abstract string Desconto(int valor);
        
    }
}