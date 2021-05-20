namespace AulaPOOCelular_1905
{
    public class Celular
    {
        public string cor = "Preto";
        public string modelo = "Samsung Galaxy A50 ";
        public int tamanho = 16;
        public bool ligado;

        public bool Ligar()
        {
            return ligado = true;
        }
        public bool Desligar()
        {
            return ligado = false;
        }
        public string FazerLigacao()
        {
            return "LIGAR";
        }
        public string EnviarMensagem()
        {
            return "MENSAGEM";
        }
    }
}
